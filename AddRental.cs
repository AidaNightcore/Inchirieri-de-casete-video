using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Inchirieri_de_casete_video
{
    public partial class AddRental : Form
    {
        private List<Rental> rentals;
        private DataAccess dataAccess;
        private PrintDocument printDocument;

        public AddRental(List<Rental> rentals)
        {
            InitializeComponent();

            this.rentals = rentals;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\Ase\\POO\\Inchirieri de casete video\\InchiriereCasete.accdb\"";
            this.dataAccess = new DataAccess(connectionString);

            PopulateClientComboBox();
            PopulateMovieComboBox();


            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void PopulateClientComboBox()
        {
            List<Client> clients = dataAccess.GetClients();
            clientNameTB.DataSource = clients;
            clientNameTB.DisplayMember = "ClientName";
            clientNameTB.ValueMember = "Id";
        }

        private void PopulateMovieComboBox()
        {
            List<Movie> movies = dataAccess.GetMovies();
            movieNameTB.DataSource = movies;
            movieNameTB.DisplayMember = "MovieTitle";
            movieNameTB.ValueMember = "Id";


            movieNameTB.SelectedIndexChanged += MovieNameTB_SelectedIndexChanged;


            if (movies.Count > 0)
            {
                Movie selectedMovie = (Movie)movieNameTB.SelectedItem;
                UpdatePricePerDayLabel(selectedMovie.Price);
                UpdateCopiesLeftLabel(selectedMovie.Copies);
            }
        }


        private void MovieNameTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedItem != null)
            {
                Movie selectedMovie = (Movie)comboBox.SelectedItem;
                UpdatePricePerDayLabel(selectedMovie.Price);
                UpdateCopiesLeftLabel(selectedMovie.Copies);
                UpdateTotalPriceAndDaysRented();
            }
        }


        private void ReturnDatePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPriceAndDaysRented();
        }


        private void UpdateTotalPriceAndDaysRented()
        {
            if (movieNameTB.SelectedItem != null)
            {
                Movie selectedMovie = (Movie)movieNameTB.SelectedItem;
                DateTime rentalDate = DateTime.Now;
                DateTime dueDate = returnDatePicker.Value;
                int daysRented = (dueDate - rentalDate).Days;
                decimal totalPrice = CalculateTotalPrice(daysRented, selectedMovie);

                UpdateTotalPriceLabel(totalPrice);
                UpdateDaysRentedLabel(daysRented);
            }
        }

        private void addRentalBtn_Click(object sender, EventArgs e)
        {
            string clientId = clientNameTB.SelectedValue?.ToString();
            string movieId = movieNameTB.SelectedValue?.ToString();
            int parsedClientId, parsedMovieId;

            if (!int.TryParse(clientId, out parsedClientId) || !int.TryParse(movieId, out parsedMovieId))
            {
                MessageBox.Show("Please select a client and a movie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Client> clients = dataAccess.GetClients();
            List<Movie> movies = dataAccess.GetMovies();
            Client selectedClient = clients.Find(c => c.Id.ToString() == clientId);
            Movie selectedMovie = movies.Find(m => m.Id.ToString() == movieId);
            DateTime rentalDate = DateTime.Now;
            DateTime dueDate = returnDatePicker.Value;

            int daysRented = (dueDate - rentalDate).Days;

            if (selectedMovie.Copies <= 0)
            {
                MessageBox.Show("There are no copies left for this movie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalPrice = CalculateTotalPrice(daysRented, selectedMovie);

            Random random = new Random();
            int id = random.Next();
            UpdatePricePerDayLabel(selectedMovie.Price);
            int updatedCopies = selectedMovie.Copies - 1;
            UpdateCopiesLeftLabel(updatedCopies);

            dataAccess.UpdateMovieCopies(parsedMovieId, updatedCopies);

            Rental newRental = new Rental(id, parsedClientId, parsedMovieId, totalPrice, rentalDate, dueDate);

            if (!newRental.CanRent(selectedClient, selectedMovie))
            {
                MessageBox.Show("Cannot rent the selected movie for the selected client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rentals.Add(newRental);
                MessageBox.Show("Rental added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }





        private decimal CalculateTotalPrice(int daysRented, Movie selectedMovie)
        {
            return selectedMovie.Price * daysRented;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRental_Load(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Fill(this.inchiriereCaseteDataSet.Clients);
            this.moviesTableAdapter.Fill(this.inchiriereCaseteMovies.Movies);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }


        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);


            string movieName = movieNameTB.Text;
            string clientName = clientNameTB.Text;
            DateTime dueDate = returnDatePicker.Value;
            string totalPrice = priceTotalLBL.Text;
            string daysRented = daysRentedlabelShow.Text;


            string details = $"Movie Name: {movieName}\n" +
                             $"Client Name: {clientName}\n" +
                             $"Due Date: {dueDate.ToShortDateString()}\n" +
                             $"Total Price: {totalPrice}\n" +
                             $"Days Rented: {daysRented}";

            e.Graphics.DrawString(details, font, brush, new PointF(100, 100));
        }

        private void UpdatePricePerDayLabel(decimal price)
        {
            priceDayLabel.Text = price.ToString();
        }

        private void UpdateCopiesLeftLabel(int copies)
        {
            copiesLeftLBL.Text = copies.ToString();
        }

        private void UpdateTotalPriceLabel(decimal totalPrice)
        {
            priceTotalLBL.Text = totalPrice.ToString();
        }

        private void UpdateDaysRentedLabel(int daysRented)
        {
            daysRentedlabelShow.Text = daysRented.ToString();
        }
    }
}
