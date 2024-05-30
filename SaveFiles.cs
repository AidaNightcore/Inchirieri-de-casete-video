using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace Inchirieri_de_casete_video
{
    public class DataAccess
    {
        private string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void ExecuteNonQuery(string query, List<OleDbParameter> parameters = null)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbTransaction transaction = null;

                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    using (OleDbCommand command = new OleDbCommand(query, connection, transaction))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters.ToArray());
                        }

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }

                    throw new Exception("Error executing non-query command", ex);
                }
            }
        }

        public object ExecuteScalar(string query, List<OleDbParameter> parameters = null)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters.ToArray());
                    }

                    return command.ExecuteScalar();
                }
            }
        }

        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            string query = "SELECT ID, FirstName, Surname, BirthdayDate, Phone, Address FROM Clients";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clients.Add(new Client(
                                reader["ID"].ToString(),
                                reader["FirstName"].ToString(),
                                reader["Surname"].ToString(),
                                reader["Phone"].ToString(),
                                Convert.ToDateTime(reader["BirthdayDate"]),
                                reader["Address"].ToString()
                            ));
                        }
                    }
                }
            }

            return clients;
        }

        public void AddClient(Client client)
        {
            string query = "INSERT INTO Clients (ID, FirstName, Surname, BirthdayDate, Phone, Address) VALUES (?, ?, ?, ?, ?, ?)";
            List<OleDbParameter> parameters = new List<OleDbParameter>
          {
            new OleDbParameter("ID", client.Id),
            new OleDbParameter("FirstName", client.Name),
            new OleDbParameter("Surname", client.Surname),
            new OleDbParameter("BirthdayDate", client.BirthdayDate),
            new OleDbParameter("Phone", client.Phone),
            new OleDbParameter("Address", client.Address)
          };

            ExecuteNonQuery(query, parameters);
        }

        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>();
            string query = "SELECT ID, MovieName, Price, AgeRating, Rating, PublishDate, Copies, Genre, Languages FROM Movies";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Movie movie = new Movie(
                                reader["ID"].ToString(),
                                reader["MovieName"].ToString(),
                                Convert.ToDecimal(reader["Price"]),
                                (AgeRating)Enum.Parse(typeof(AgeRating), reader["AgeRating"].ToString()),
                                Convert.ToInt32(reader["Rating"]),
                                Convert.ToDateTime(reader["PublishDate"]),
                                Convert.ToInt32(reader["Copies"]),
                                (Genre)Genre.Parse(typeof(Genre), reader["Genre"].ToString()),
                                reader["Languages"].ToString().Split(',')
                            );
                            movies.Add(movie);
                        }
                    }
                }
            }

            return movies;
        }

        public void AddMovie(Movie movie)
        {
            string query = "INSERT INTO Movies (ID, MovieName, Price, AgeRating, Rating, PublishDate, Copies, Genre, Languages) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
            List<OleDbParameter> parameters = new List<OleDbParameter>
            {
                new OleDbParameter("ID", movie.Id),
                new OleDbParameter("MovieName", movie.Name),
                new OleDbParameter("Price", movie.Price),
                new OleDbParameter("AgeRating", movie.AgeRating.ToString()),
                new OleDbParameter("Rating", movie.Rating),
                new OleDbParameter("PublishDate", movie.PublishDate),
                new OleDbParameter("Copies", movie.Copies),
                new OleDbParameter("Genre", movie.Genre.ToString()),
                new OleDbParameter("Languages", string.Join(",", movie.Languages))
            };

            ExecuteNonQuery(query, parameters);
        }

        public List<Rental> GetRentals()
        {
            List<Rental> rentals = new List<Rental>();
            string query = "SELECT ID, ClientId, MovieId, TotalPrice, RentDate, DueDate FROM Rentals";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {


                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rentals.Add(new Rental(
                                reader["ID"].ToString(),
                                reader["ClientId"].ToString(),
                                reader["MovieId"].ToString(),
                                Convert.ToDecimal(reader["TotalPrice"]),
                                Convert.ToDateTime(reader["RentDate"]),
                                Convert.ToDateTime(reader["DueDate"])
                            ));
                        }
                    }
                }
            }

            return rentals;
        }

        public void AddRental(Rental rental)
        {
            string query = "INSERT INTO Rentals (ID, ClientId, MovieId, TotalPrice, RentDate, DueDate) VALUES (?, ?, ?, ?, ?, ?)";
            List<OleDbParameter> parameters = new List<OleDbParameter>
            {
                
                new OleDbParameter("ID", rental.Id),
                new OleDbParameter("ClientId", rental.ClientId),
                new OleDbParameter("TotalPrice", rental.TotalPrice),
                new OleDbParameter("MovieId", rental.MovieId),
                new OleDbParameter("RentDate", rental.RentalDate),
                new OleDbParameter("DueDate", rental.DueDate)
            };

            ExecuteNonQuery(query, parameters);
        }

        public void DeleteRental(string clientId, string movieId)
        {
            string query = "DELETE FROM Rentals WHERE ClientId = ? AND MovieId = ?";
            List<OleDbParameter> parameters = new List<OleDbParameter>
            {
                new OleDbParameter("ClientId", clientId),
                new OleDbParameter("MovieId", movieId)
            };

            ExecuteNonQuery(query, parameters);
        }

        public void UpdateClient(Client client)
        {
            string query = "UPDATE Clients SET FirstName = ?, Surname = ?, BirthdayDate = ?, Phone = ?, Address = ? WHERE ID = ?";
            List<OleDbParameter> parameters = new List<OleDbParameter>
            {
                new OleDbParameter("FirstName", client.Name),
                new OleDbParameter("Surname", client.Surname),
                new OleDbParameter("BirthdayDate", client.BirthdayDate),
                new OleDbParameter("Phone", client.Phone),
                new OleDbParameter("Address", client.Address),
                new OleDbParameter("ID", client.Id)
            };

            ExecuteNonQuery(query, parameters);
        }

        public void DeleteClient(string clientId)
        {
            string query = "DELETE FROM Clients WHERE ID = ?";
            List<OleDbParameter> parameters = new List<OleDbParameter>
            {
                new OleDbParameter("ID", clientId)
            };

            ExecuteNonQuery(query, parameters);
        }
    }
}
