namespace Inchirieri_de_casete_video
{
    partial class AddRental
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
            this.returnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addRentalBtn = new System.Windows.Forms.Button();
            this.movieNameLabel = new System.Windows.Forms.Label();
            this.barPanel = new System.Windows.Forms.Panel();
            this.windowTitleLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.priceTotalLabel = new System.Windows.Forms.Label();
            this.daysRentedLabel = new System.Windows.Forms.Label();
            this.priceTotalLBL = new System.Windows.Forms.Label();
            this.daysRentedlabelShow = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceDayLabel = new System.Windows.Forms.Label();
            this.copiesLeftLabel = new System.Windows.Forms.Label();
            this.copiesLeftLBL = new System.Windows.Forms.Label();
            this.clientNameTB = new System.Windows.Forms.ComboBox();
            this.movieNameTB = new System.Windows.Forms.ComboBox();
            this.inchiriereCaseteMovies = new Inchirieri_de_casete_video.InchiriereCaseteMovies();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new Inchirieri_de_casete_video.InchiriereCaseteMoviesTableAdapters.MoviesTableAdapter();
            this.inchiriereCaseteDataSet = new Inchirieri_de_casete_video.InchiriereCaseteDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Inchirieri_de_casete_video.InchiriereCaseteDataSetTableAdapters.ClientsTableAdapter();
            this.barPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriereCaseteMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriereCaseteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // returnDatePicker
            // 
            this.returnDatePicker.Location = new System.Drawing.Point(31, 278);
            this.returnDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnDatePicker.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.returnDatePicker.Name = "returnDatePicker";
            this.returnDatePicker.Size = new System.Drawing.Size(283, 26);
            this.returnDatePicker.TabIndex = 25;
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Location = new System.Drawing.Point(25, 243);
            this.returnDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(97, 20);
            this.returnDateLabel.TabIndex = 30;
            this.returnDateLabel.Text = "Return Date";
            // 
            // cancelBtn
            // 
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cancelBtn.Location = new System.Drawing.Point(343, 339);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(150, 43);
            this.cancelBtn.TabIndex = 28;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addRentalBtn
            // 
            this.addRentalBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.addRentalBtn.Location = new System.Drawing.Point(176, 339);
            this.addRentalBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addRentalBtn.Name = "addRentalBtn";
            this.addRentalBtn.Size = new System.Drawing.Size(150, 43);
            this.addRentalBtn.TabIndex = 26;
            this.addRentalBtn.Text = "Add";
            this.addRentalBtn.UseVisualStyleBackColor = true;
            this.addRentalBtn.Click += new System.EventHandler(this.addRentalBtn_Click);
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.AutoSize = true;
            this.movieNameLabel.Location = new System.Drawing.Point(25, 77);
            this.movieNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Size = new System.Drawing.Size(96, 20);
            this.movieNameLabel.TabIndex = 23;
            this.movieNameLabel.Text = "Movie Name";
            // 
            // barPanel
            // 
            this.barPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.barPanel.Controls.Add(this.windowTitleLabel);
            this.barPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.barPanel.Location = new System.Drawing.Point(2, 0);
            this.barPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barPanel.Name = "barPanel";
            this.barPanel.Size = new System.Drawing.Size(781, 49);
            this.barPanel.TabIndex = 27;
            // 
            // windowTitleLabel
            // 
            this.windowTitleLabel.AutoSize = true;
            this.windowTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitleLabel.Location = new System.Drawing.Point(16, 9);
            this.windowTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windowTitleLabel.Name = "windowTitleLabel";
            this.windowTitleLabel.Size = new System.Drawing.Size(120, 25);
            this.windowTitleLabel.TabIndex = 0;
            this.windowTitleLabel.Text = "Rent movie";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(25, 157);
            this.clientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(95, 20);
            this.clientNameLabel.TabIndex = 40;
            this.clientNameLabel.Text = "Client Name";
            // 
            // priceTotalLabel
            // 
            this.priceTotalLabel.AutoSize = true;
            this.priceTotalLabel.Location = new System.Drawing.Point(351, 212);
            this.priceTotalLabel.Name = "priceTotalLabel";
            this.priceTotalLabel.Size = new System.Drawing.Size(82, 20);
            this.priceTotalLabel.TabIndex = 42;
            this.priceTotalLabel.Text = "Total price";
            // 
            // daysRentedLabel
            // 
            this.daysRentedLabel.AutoSize = true;
            this.daysRentedLabel.Location = new System.Drawing.Point(515, 212);
            this.daysRentedLabel.Name = "daysRentedLabel";
            this.daysRentedLabel.Size = new System.Drawing.Size(95, 20);
            this.daysRentedLabel.TabIndex = 43;
            this.daysRentedLabel.Text = "Days rented";
            // 
            // priceTotalLBL
            // 
            this.priceTotalLBL.AutoSize = true;
            this.priceTotalLBL.Location = new System.Drawing.Point(368, 248);
            this.priceTotalLBL.Name = "priceTotalLBL";
            this.priceTotalLBL.Size = new System.Drawing.Size(18, 20);
            this.priceTotalLBL.TabIndex = 44;
            this.priceTotalLBL.Text = "0";
            // 
            // daysRentedlabelShow
            // 
            this.daysRentedlabelShow.AutoSize = true;
            this.daysRentedlabelShow.Location = new System.Drawing.Point(537, 248);
            this.daysRentedlabelShow.Name = "daysRentedlabelShow";
            this.daysRentedlabelShow.Size = new System.Drawing.Size(18, 20);
            this.daysRentedlabelShow.TabIndex = 45;
            this.daysRentedlabelShow.Text = "0";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(351, 126);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(77, 20);
            this.priceLabel.TabIndex = 46;
            this.priceLabel.Text = "Price/ day";
            // 
            // priceDayLabel
            // 
            this.priceDayLabel.AutoSize = true;
            this.priceDayLabel.Location = new System.Drawing.Point(364, 160);
            this.priceDayLabel.Name = "priceDayLabel";
            this.priceDayLabel.Size = new System.Drawing.Size(18, 20);
            this.priceDayLabel.TabIndex = 47;
            this.priceDayLabel.Text = "0";
            // 
            // copiesLeftLabel
            // 
            this.copiesLeftLabel.AutoSize = true;
            this.copiesLeftLabel.Location = new System.Drawing.Point(515, 126);
            this.copiesLeftLabel.Name = "copiesLeftLabel";
            this.copiesLeftLabel.Size = new System.Drawing.Size(90, 20);
            this.copiesLeftLabel.TabIndex = 49;
            this.copiesLeftLabel.Text = "Copies Left";
            // 
            // copiesLeftLBL
            // 
            this.copiesLeftLBL.AutoSize = true;
            this.copiesLeftLBL.Location = new System.Drawing.Point(537, 160);
            this.copiesLeftLBL.Name = "copiesLeftLBL";
            this.copiesLeftLBL.Size = new System.Drawing.Size(18, 20);
            this.copiesLeftLBL.TabIndex = 50;
            this.copiesLeftLBL.Text = "0";
            // 
            // clientNameTB
            // 
            this.clientNameTB.DataSource = this.clientsBindingSource;
            this.clientNameTB.FormattingEnabled = true;
            this.clientNameTB.Location = new System.Drawing.Point(31, 191);
            this.clientNameTB.Name = "clientNameTB";
            this.clientNameTB.Size = new System.Drawing.Size(283, 28);
            this.clientNameTB.TabIndex = 51;
            // 
            // movieNameTB
            // 
            this.movieNameTB.DataSource = this.moviesBindingSource;
            this.movieNameTB.FormattingEnabled = true;
            this.movieNameTB.Location = new System.Drawing.Point(31, 106);
            this.movieNameTB.Name = "movieNameTB";
            this.movieNameTB.Size = new System.Drawing.Size(283, 28);
            this.movieNameTB.TabIndex = 52;
            // 
            // inchiriereCaseteMovies
            // 
            this.inchiriereCaseteMovies.DataSetName = "InchiriereCaseteMovies";
            this.inchiriereCaseteMovies.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.inchiriereCaseteMovies;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // inchiriereCaseteDataSet
            // 
            this.inchiriereCaseteDataSet.DataSetName = "InchiriereCaseteDataSet";
            this.inchiriereCaseteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.inchiriereCaseteDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // AddRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(655, 410);
            this.Controls.Add(this.movieNameTB);
            this.Controls.Add(this.clientNameTB);
            this.Controls.Add(this.copiesLeftLBL);
            this.Controls.Add(this.copiesLeftLabel);
            this.Controls.Add(this.priceDayLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.daysRentedlabelShow);
            this.Controls.Add(this.priceTotalLBL);
            this.Controls.Add(this.daysRentedLabel);
            this.Controls.Add(this.priceTotalLabel);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.returnDatePicker);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addRentalBtn);
            this.Controls.Add(this.movieNameLabel);
            this.Controls.Add(this.barPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddRental";
            this.Text = "AddRental";
            this.Load += new System.EventHandler(this.AddRental_Load);
            this.barPanel.ResumeLayout(false);
            this.barPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriereCaseteMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriereCaseteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker returnDatePicker;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addRentalBtn;
        private System.Windows.Forms.Label movieNameLabel;
        private System.Windows.Forms.Panel barPanel;
        private System.Windows.Forms.Label windowTitleLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label priceTotalLabel;
        private System.Windows.Forms.Label daysRentedLabel;
        private System.Windows.Forms.Label priceTotalLBL;
        private System.Windows.Forms.Label daysRentedlabelShow;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label priceDayLabel;
        private System.Windows.Forms.Label copiesLeftLabel;
        private System.Windows.Forms.Label copiesLeftLBL;
        private System.Windows.Forms.ComboBox clientNameTB;
        private System.Windows.Forms.ComboBox movieNameTB;
        private InchiriereCaseteMovies inchiriereCaseteMovies;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private InchiriereCaseteMoviesTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private InchiriereCaseteDataSet inchiriereCaseteDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private InchiriereCaseteDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
    }
}