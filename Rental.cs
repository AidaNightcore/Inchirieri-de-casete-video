using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inchirieri_de_casete_video
{
    public class Rental{
        private string id;
        private string clientId;
        private string movieId;
        private int totalPrice;
        private int daysRented;

        public string Id { get => id; set => id = value; }
        public string ClientId { get => clientId; set => clientId = value; }
        public string MovieId { get => movieId; set => movieId = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int DaysRented { get => daysRented; set => daysRented = value; }

        public Rental(string v_id, string v_clientId, string v_movieId, int v_totalPrice, int v_daysRented)
        {
            id = v_id;
            clientId = v_clientId;
            movieId= v_movieId;
            totalPrice = v_totalPrice;
            daysRented = v_daysRented;
        }
    }
}
