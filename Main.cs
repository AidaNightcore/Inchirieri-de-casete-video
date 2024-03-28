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
        private List<Movie> movieList;
        private List<Rental> rentalList;
        private DataHandler dataHandler;

        public Main()
        {
            InitializeComponent();
            
            InitializeDataHandler(); 
            clientsList = new List<Client>(); 
            movieList = new List<Movie>(); 
            rentalList = new List<Rental>(); 
            clientsList = new List<Client>();
        }

        private void InitializeDataHandler()
        {
            // Define file paths for data storage
            string clientsFilePath = "clients.txt";
            string moviesFilePath = "movies.txt";
            string rentalsFilePath = "rentals.txt";

            // Create DataHandler instance
            dataHandler = new DataHandler(clientsFilePath, moviesFilePath, rentalsFilePath);
        }

        private void clientMenu_Click(object sender, EventArgs e)
        {
            AddClient addClientForm = new AddClient();
            addClientForm.ShowDialog();
        }

        private void deleteUsers_Click(object sender, EventArgs e)
        {

        }
        

        private void addClients_Click(object sender, EventArgs e)
        {
            AddClient addClientForm = new AddClient();
            addClientForm.ShowDialog();
        }
        

        private void addMovie_Click(object sender, EventArgs e)
        {
            AddMovie addMovieForm = new AddMovie();
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
            AddMovie addMovieForm = new AddMovie();
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
    }
}
