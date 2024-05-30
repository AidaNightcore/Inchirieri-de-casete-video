using System.Drawing;
using System.Windows.Forms;

namespace Inchirieri_de_casete_video
{
    partial class Main:Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.clientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsSubMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addClients = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesSubMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsSubMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRental = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRental = new System.Windows.Forms.ToolStripMenuItem();
            this.inchiriereCaseteMovies = new Inchirieri_de_casete_video.InchiriereCaseteMovies();
            this.inchiriereCaseteMoviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inchiriereCaseteDataSet1 = new Inchirieri_de_casete_video.InchiriereCaseteDataSet1();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Inchirieri_de_casete_video.InchiriereCaseteDataSet1TableAdapters.ClientsTableAdapter();
            this.mainMenu.SuspendLayout();
            this.clientsSubMenu.SuspendLayout();
            this.moviesSubMenu.SuspendLayout();
            this.rentalsSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriereCaseteMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriereCaseteMoviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriereCaseteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientMenu,
            this.moviesMenu,
            this.rentalsMenu});
            this.mainMenu.Location = new System.Drawing.Point(5, 5);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1190, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // clientMenu
            // 
            this.clientMenu.Name = "clientMenu";
            this.clientMenu.Size = new System.Drawing.Size(55, 20);
            this.clientMenu.Text = "Clients";
            this.clientMenu.Click += new System.EventHandler(this.clientMenu_Click);
            // 
            // moviesMenu
            // 
            this.moviesMenu.Name = "moviesMenu";
            this.moviesMenu.Size = new System.Drawing.Size(57, 20);
            this.moviesMenu.Text = "Movies";
            this.moviesMenu.Click += new System.EventHandler(this.moviesMenu_Click);
            // 
            // rentalsMenu
            // 
            this.rentalsMenu.Name = "rentalsMenu";
            this.rentalsMenu.Size = new System.Drawing.Size(57, 20);
            this.rentalsMenu.Text = "Rentals";
            this.rentalsMenu.Click += new System.EventHandler(this.rentalsMenu_Click);
            // 
            // clientsSubMenu
            // 
            this.clientsSubMenu.AllowMerge = false;
            this.clientsSubMenu.AutoClose = false;
            this.clientsSubMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClients,
            this.deleteUsers});
            this.clientsSubMenu.Name = "subMenu";
            this.clientsSubMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // addClients
            // 
            this.addClients.Name = "addClients";
            this.addClients.Size = new System.Drawing.Size(107, 22);
            this.addClients.Text = "Add";
            this.addClients.Click += new System.EventHandler(this.addClients_Click);
            // 
            // deleteUsers
            // 
            this.deleteUsers.Name = "deleteUsers";
            this.deleteUsers.Size = new System.Drawing.Size(107, 22);
            this.deleteUsers.Text = "Delete";
            this.deleteUsers.Click += new System.EventHandler(this.deleteUsers_Click);
            // 
            // moviesSubMenu
            // 
            this.moviesSubMenu.AllowMerge = false;
            this.moviesSubMenu.AutoClose = false;
            this.moviesSubMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMovie,
            this.deleteMovie});
            this.moviesSubMenu.Name = "subMenu";
            this.moviesSubMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // addMovie
            // 
            this.addMovie.Name = "addMovie";
            this.addMovie.Size = new System.Drawing.Size(107, 22);
            this.addMovie.Text = "Add";
            this.addMovie.Click += new System.EventHandler(this.addMovie_Click);
            // 
            // deleteMovie
            // 
            this.deleteMovie.Name = "deleteMovie";
            this.deleteMovie.Size = new System.Drawing.Size(107, 22);
            this.deleteMovie.Text = "Delete";
            this.deleteMovie.Click += new System.EventHandler(this.deleteMovie_Click);
            // 
            // rentalsSubMenu
            // 
            this.rentalsSubMenu.AllowMerge = false;
            this.rentalsSubMenu.AutoClose = false;
            this.rentalsSubMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRental,
            this.deleteRental});
            this.rentalsSubMenu.Name = "subMenu";
            this.rentalsSubMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // addRental
            // 
            this.addRental.Name = "addRental";
            this.addRental.Size = new System.Drawing.Size(107, 22);
            this.addRental.Text = "Add";
            this.addRental.Click += new System.EventHandler(this.addRental_Click);
            // 
            // deleteRental
            // 
            this.deleteRental.Name = "deleteRental";
            this.deleteRental.Size = new System.Drawing.Size(107, 22);
            this.deleteRental.Text = "Delete";
            this.deleteRental.Click += new System.EventHandler(this.deleteRental_Click);
            // 
            // inchiriereCaseteMovies
            // 
            this.inchiriereCaseteMovies.DataSetName = "InchiriereCaseteMovies";
            this.inchiriereCaseteMovies.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inchiriereCaseteMoviesBindingSource
            // 
            this.inchiriereCaseteMoviesBindingSource.DataSource = this.inchiriereCaseteMovies;
            this.inchiriereCaseteMoviesBindingSource.Position = 0;
            // 
            // inchiriereCaseteDataSet1
            // 
            this.inchiriereCaseteDataSet1.DataSetName = "InchiriereCaseteDataSet1";
            this.inchiriereCaseteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.inchiriereCaseteDataSet1;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Movie Cassetes";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.clientsSubMenu.ResumeLayout(false);
            this.moviesSubMenu.ResumeLayout(false);
            this.rentalsSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inchiriereCaseteMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriereCaseteMoviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriereCaseteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem clientMenu;
        private ToolStripMenuItem moviesMenu;
        private ToolStripMenuItem rentalsMenu;
        private ContextMenuStrip clientsSubMenu;
        private ToolStripMenuItem addClients;
        private ToolStripMenuItem deleteUsers;
        private ContextMenuStrip moviesSubMenu;
        private ToolStripMenuItem addMovie;
        private ToolStripMenuItem deleteMovie;
        private ContextMenuStrip rentalsSubMenu;
        private ToolStripMenuItem addRental;
        private ToolStripMenuItem deleteRental;
        private BindingSource inchiriereCaseteMoviesBindingSource;
        private InchiriereCaseteMovies inchiriereCaseteMovies;
        private InchiriereCaseteDataSet1 inchiriereCaseteDataSet1;
        private BindingSource clientsBindingSource;
        private InchiriereCaseteDataSet1TableAdapters.ClientsTableAdapter clientsTableAdapter;
    }
}