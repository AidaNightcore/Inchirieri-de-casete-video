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
        public Main()
        {
            InitializeComponent();
            itemsControlMenu.Show(); 
            // Adaugă un eveniment pentru fiecare element de meniu pentru a gestiona acțiunile
            foreach (ToolStripMenuItem item in itemsControlMenu.Items)
            {
                item.Click += (sender, e) =>
                {
                    switch (item.Text)
                    {
                        case "Add User":
                            // Deschide un formular nou pentru adăugarea unui utilizator
                            AddClient addUserForm = new AddClient();
                            addUserForm.ShowDialog();
                            break;
                        case "View Users":
                            // Deschide un formular nou pentru vizualizarea utilizatorilor
                            AddClient viewUsersForm = new AddClient();
                            viewUsersForm.Show();
                            break;
                            // Adaugă alte cazuri pentru alte elemente de meniu dacă este necesar
                    }
                };
            }

            // Atașează un eveniment pentru meniul contextual pentru a ascunde meniul când este pierdut focusul
            itemsControlMenu.Closing += (sender, e) =>
            {
                // Ascunde meniul contextual doar dacă închiderea este cauzată de pierderea focusului către altă fereastră din meniu
                if (e.CloseReason == ToolStripDropDownCloseReason.AppClicked || e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
                {
                    e.Cancel = true;
                }
            };

            // Afișează meniul contextual la poziția specificată în formular
            itemsControlMenu.Show(functionPanel, new Point(0, functionPanel.Height));
        
    }
    }
}
