using System;
using System.Windows.Forms;

namespace Inchirieri_de_casete_video
{
    public partial class AddClient : Form
    {
        private DataAccess dataAccess;

        public AddClient(DataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
            InitializeComponent();
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int id = random.Next();
                string name = clientNameTB.Text;
                string surname = clientSurnameTB.Text;
                string phone = phoneTB.Text;
                DateTime birthdayDate = birthdayDatePicker.Value;
                string address = adressTB.Text;

                Client newClient = new Client(id, name, surname, phone, birthdayDate, address);
                dataAccess.AddClient(newClient);
                MessageBox.Show("Client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
