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
            clientNameTB.Items.Clear();
            List<Client> clients = dataAccess.GetClients();
            foreach (Client client in clients)
            {
                clientNameTB.Items.Add(client.Id);
            }
        }

        private void PopulateMovieComboBox()
        {
            movieNameTB.Items.Clear();
            List<Movie> movies = dataAccess.GetMovies();
            foreach (Movie movie in movies)
            {
                movieNameTB.Items.Add(movie.Id);
            }
        }

        private void addRentalBtn_Click(object sender, EventArgs e)
        {
            string clientId = clientNameTB.SelectedItem?.ToString();
            string movieId = movieNameTB.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(movieId))
            {
                MessageBox.Show("Please select a client and a movie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Client> clients = dataAccess.GetClients();
            List<Movie> movies = dataAccess.GetMovies();
            Client selectedClient = clients.Find(c => c.Id == clientId);
            Movie selectedMovie = movies.Find(m => m.Id == movieId);
            DateTime rentalDate = DateTime.Now;
            DateTime dueDate = returnDatePicker.Value;

            int daysRented = (dueDate - rentalDate).Days;

            decimal totalPrice = CalculateTotalPrice(daysRented, selectedMovie);

            // Update labels
            priceDayLabel.Text = selectedMovie.Price.ToString();
            copiesLeftLBL.Text = selectedMovie.Copies.ToString();
            priceTotalLBL.Text = totalPrice.ToString();
            daysRentedlabelShow.Text = daysRented.ToString();

            Rental newRental = new Rental(Guid.NewGuid().ToString(), clientId, movieId, totalPrice, rentalDate, dueDate);

            if (newRental.CanRent(selectedClient, selectedMovie))
            {
                rentals.Add(newRental);
                MessageBox.Show("Rental added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cannot rent the selected movie for the selected client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
