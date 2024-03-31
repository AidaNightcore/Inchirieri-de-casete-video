using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchirieri_de_casete_video
{
    public partial class Main : Form
    {

        private List<Client> clientsList;
        private List<Movie> moviesList;
        private List<Rental> rentalsList;
        private DataHandler dataHandler;
        string clientsFilePath = "clients.txt";
        string moviesFilePath = "movies.txt";
        string rentalsFilePath = "rentals.txt";
        public Main()
        {
            InitializeComponent();
            InitializeDataHandler(clientsFilePath, moviesFilePath, rentalsFilePath); 

            clientsList = new List<Client>(); 
            moviesList = new List<Movie>(); 
            rentalsList = new List<Rental>(); 
        }

        private void InitializeDataHandler(string clientsFilePath, string moviesFilePath, string rentalsFilePath)
        {
            dataHandler = new DataHandler(clientsFilePath, moviesFilePath, rentalsFilePath);
        }

        private void clientMenu_Click(object sender, EventArgs e)
        {
            AddClient addClientForm = new AddClient(clientsList, clientsFilePath);
            addClientForm.ShowDialog();
        }

        private void deleteUsers_Click(object sender, EventArgs e)
        {

        }
        

        private void addClients_Click(object sender, EventArgs e)
        {
            AddClient addClientForm = new AddClient(clientsList, clientsFilePath);
            addClientForm.ShowDialog();
        }
        

        private void addMovie_Click(object sender, EventArgs e)
        {
            AddMovie addMovieForm = new AddMovie(moviesList, moviesFilePath);
            addMovieForm.ShowDialog();
        }

        private void deleteMovie_Click(object sender, EventArgs e)
        {

        }

        private void addRental_Click(object sender, EventArgs e)
        {
            AddRental rentMovieForm = new AddRental();
            rentMovieForm.ShowDialog();
        }

        private void deleteRental_Click(object sender, EventArgs e)
        {

        }

        private void moviesMenu_Click(object sender, EventArgs e)
        {
            AddMovie addMovieForm = new AddMovie(moviesList, moviesFilePath);
            addMovieForm.ShowDialog();
        }

        private void rentalsMenu_Click(object sender, EventArgs e)
        {
            AddRental rentMovieForm = new AddRental();
            rentMovieForm.ShowDialog();
        }
        public void AddClientToList(Client client)
        {
            clientsList.Add(client);
        }
        public void AddMovieToList(Movie movie)
        {
            moviesList.Add(movie);
        }
        public void AddRentalToList(Rental rental)
        {
            rentalsList.Add(rental);
        }
    }
}
