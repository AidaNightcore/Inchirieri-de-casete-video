using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inchirieri_de_casete_video
{
    public partial class AddRental : Form
    {
        private List<Rental> rentals;
        private DataAccess dataAccess;

        public AddRental(List<Rental> rentals)
        {
            InitializeComponent();

            this.rentals = rentals;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\Ase\\POO\\Inchirieri de casete video\\InchiriereCasete.accdb\"";
            this.dataAccess = new DataAccess(connectionString);

            PopulateClientComboBox();
            PopulateMovieComboBox();
        }

        private void PopulateClientComboBox()
        {
            List<Client> clients = dataAccess.GetClients();
            clientNameTB.DataSource = clients;
            clientNameTB.DisplayMember = "ClientName"; // Assuming Client class has a Name property
            clientNameTB.ValueMember = "Id";
        }

        private void PopulateMovieComboBox()
        {
            List<Movie> movies = dataAccess.GetMovies();
            movieNameTB.DataSource = movies;
            movieNameTB.DisplayMember = "MovieTitle"; // Assuming Movie class has a Title property
            movieNameTB.ValueMember = "Id";
        }

        private void addRentalBtn_Click(object sender, EventArgs e)
        {
            
            string clientId = clientNameTB.SelectedValue?.ToString();
            string movieId = movieNameTB.SelectedValue?.ToString();
            int parsedClientId = int.Parse(clientId);
            int parsedMovieId = int.Parse(movieId);
            if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(movieId))
            {
                MessageBox.Show("Please select a client and a movie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Client> clients = dataAccess.GetClients();
            List<Movie> movies = dataAccess.GetMovies();
            Client selectedClient = clients.Find(c => c.Id.ToString() == clientId.ToString());
            Movie selectedMovie = movies.Find(m => m.Id.ToString() == movieId.ToString());
            DateTime rentalDate = DateTime.Now;
            DateTime dueDate = returnDatePicker.Value;

            int daysRented = (dueDate - rentalDate).Days;

            decimal totalPrice = CalculateTotalPrice(daysRented, selectedMovie);

            Random random = new Random();
            int id = random.Next();
            priceDayLabel.Text = selectedMovie.Price.ToString();
            copiesLeftLBL.Text = selectedMovie.Copies.ToString();
            priceTotalLBL.Text = totalPrice.ToString();
            daysRentedlabelShow.Text = daysRented.ToString();

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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal CalculateTotalPrice(int daysRented, Movie selectedMovie)
        {
            return selectedMovie.Price * daysRented;
        }

        private void AddRental_Load(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Fill(this.inchiriereCaseteDataSet.Clients);
            this.moviesTableAdapter.Fill(this.inchiriereCaseteMovies.Movies);
        }

        public AddRental()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(AddRental_KeyDown);
        }

        // KeyDown event handler
        private void AddRental_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                PrintRentalDetails();
                e.SuppressKeyPress = true; // Suppress the default behavior of Ctrl+P
            }
        }

        // Method to print the rental details
        private void PrintRentalDetails()
        {
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

            MessageBox.Show(details, "Rental Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
