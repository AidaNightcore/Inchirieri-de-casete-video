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
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\Ase\\POO\\Inchirieri de casete video\\InchiriereCasete.accdb\"";
        public Main()
        {
            InitializeComponent();

            clientsList = new List<Client>(); 
            moviesList = new List<Movie>(); 
            rentalsList = new List<Rental>(); 
        }


        private void clientMenu_Click(object sender, EventArgs e)
        {
            AddClient addClientForm = new AddClient(new DataAccess(connectionString));
            addClientForm.ShowDialog();
        }


        private void deleteUsers_Click(object sender, EventArgs e)
        {

        }
        

        private void addClients_Click(object sender, EventArgs e)
        {
            AddClient addClientForm = new AddClient(new DataAccess(connectionString));
            addClientForm.ShowDialog();
        }


        private void addMovie_Click(object sender, EventArgs e)
        {
            AddMovie addMovieForm = new AddMovie(new DataAccess(connectionString));
            addMovieForm.ShowDialog();
        }



        private void deleteMovie_Click(object sender, EventArgs e)
        {

        }

        private void addRental_Click(object sender, EventArgs e)
        {
            AddRental rentMovieForm = new AddRental(rentalsList);
            rentMovieForm.ShowDialog();
        }

        private void deleteRental_Click(object sender, EventArgs e)
        {

        }

        private void moviesMenu_Click(object sender, EventArgs e)
        {
            AddMovie addMovieForm = new AddMovie(new DataAccess(connectionString));
            addMovieForm.ShowDialog();
        }


        private void rentalsMenu_Click(object sender, EventArgs e)
        {
            AddRental rentMovieForm = new AddRental(rentalsList);
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

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inchiriereCaseteDataSet1.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.inchiriereCaseteDataSet1.Clients);

        }
    }
}
