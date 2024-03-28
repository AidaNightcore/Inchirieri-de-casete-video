using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inchirieri_de_casete_video
{
    public partial class AddClient : Form
    {
        private Main mainForm;
        private DataHandler dataHandler;
        public AddClient(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            
            string id = clientNameTB.Text.ToString() + clientSurnameTB.Text.ToString() ;
            string name = clientNameTB.Text;
            string surname = clientSurnameTB.Text;
            string phone = phoneTB.Text;
            DateTime birthdayDate = birthdayDatePicker.Value.Date;
            string address = adressTB.Text;

            
            Client newClient = new Client(id, name, surname, phone, birthdayDate, address);

            
            clients.Add(newClient);

            
            dataHandler.SaveClients(clients);

            
            this.Close();
            mainForm.AddClientToList(newClient);

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
