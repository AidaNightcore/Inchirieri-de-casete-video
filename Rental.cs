using System;

namespace Inchirieri_de_casete_video
{
    public class Rental
    {
        public int Id { get; private set; }
        public int ClientId { get; private set; }
        public int MovieId { get; private set; }
        public decimal TotalPrice { get; private set; }
        public DateTime RentalDate { get; private set; }
        public DateTime DueDate { get; set; }

        public Rental(int id, int clientId, int movieId, decimal totalPrice, DateTime rentalDate, DateTime dueDate)
        {
            Id = id;
            ClientId = clientId;
            MovieId = movieId;
            TotalPrice = totalPrice;
            RentalDate = rentalDate;
            DueDate = dueDate;
        }

        public override string ToString()
        {
            return $"{Id}\n{ClientId}\n{MovieId}\n{TotalPrice}\n{RentalDate}\n";
        }

        private decimal CalculateTotalPrice(decimal pricePerDay)
        {
            TimeSpan rentalPeriod = DueDate - RentalDate;
            int rentalDays = (int)Math.Ceiling(rentalPeriod.TotalDays);

            return pricePerDay * rentalDays;
        }

        public bool CanRent(Client client, Movie movie)
        {
            if (client.AgeRating() >= (int)movie.AgeRating)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
