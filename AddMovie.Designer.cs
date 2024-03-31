using System;

namespace Inchirieri_de_casete_video
{
    partial class AddMovie
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
            this.windowTitleLabel = new System.Windows.Forms.Label();
            this.barPanel = new System.Windows.Forms.Panel();
            this.movieNameLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addMovieBtn = new System.Windows.Forms.Button();
            this.movieNameTB = new System.Windows.Forms.TextBox();
            this.ageRatingLabel = new System.Windows.Forms.Label();
            this.publishDateLabel = new System.Windows.Forms.Label();
            this.moviePublishDatePicker = new System.Windows.Forms.DateTimePicker();
            this.genreLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.copiesLabel = new System.Windows.Forms.Label();
            this.langaugesLabel = new System.Windows.Forms.Label();
            this.copiesNumeric = new System.Windows.Forms.NumericUpDown();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.ageRatingDrop = new System.Windows.Forms.ComboBox();
            this.genreTB = new System.Windows.Forms.TextBox();
            this.langaugesTB = new System.Windows.Forms.TextBox();
            this.barPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copiesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // windowTitleLabel
            // 
            this.windowTitleLabel.AutoSize = true;
            this.windowTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitleLabel.Location = new System.Drawing.Point(11, 9);
            this.windowTitleLabel.Name = "windowTitleLabel";
            this.windowTitleLabel.Size = new System.Drawing.Size(113, 25);
            this.windowTitleLabel.TabIndex = 0;
            this.windowTitleLabel.Text = "Add movie";
            // 
            // barPanel
            // 
            this.barPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.barPanel.Controls.Add(this.windowTitleLabel);
            this.barPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.barPanel.Location = new System.Drawing.Point(1, 3);
            this.barPanel.Name = "barPanel";
            this.barPanel.Size = new System.Drawing.Size(552, 41);
            this.barPanel.TabIndex = 11;
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.AutoSize = true;
            this.movieNameLabel.Location = new System.Drawing.Point(29, 79);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Size = new System.Drawing.Size(96, 20);
            this.movieNameLabel.TabIndex = 1;
            this.movieNameLabel.Text = "Movie Name";
            // 
            // cancelBtn
            // 
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cancelBtn.Location = new System.Drawing.Point(289, 375);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addMovieBtn
            // 
            this.addMovieBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.addMovieBtn.Location = new System.Drawing.Point(164, 375);
            this.addMovieBtn.Name = "addMovieBtn";
            this.addMovieBtn.Size = new System.Drawing.Size(100, 28);
            this.addMovieBtn.TabIndex = 10;
            this.addMovieBtn.Text = "Add";
            this.addMovieBtn.UseVisualStyleBackColor = true;
            this.addMovieBtn.Click += new System.EventHandler(this.addMovieBtn_Click);
            // 
            // movieNameTB
            // 
            this.movieNameTB.Location = new System.Drawing.Point(33, 102);
            this.movieNameTB.Name = "movieNameTB";
            this.movieNameTB.Size = new System.Drawing.Size(270, 26);
            this.movieNameTB.TabIndex = 2;
            // 
            // ageRatingLabel
            // 
            this.ageRatingLabel.AutoSize = true;
            this.ageRatingLabel.Location = new System.Drawing.Point(345, 79);
            this.ageRatingLabel.Name = "ageRatingLabel";
            this.ageRatingLabel.Size = new System.Drawing.Size(89, 20);
            this.ageRatingLabel.TabIndex = 12;
            this.ageRatingLabel.Text = "Age Rating";
            // 
            // publishDateLabel
            // 
            this.publishDateLabel.AutoSize = true;
            this.publishDateLabel.Location = new System.Drawing.Point(29, 158);
            this.publishDateLabel.Name = "publishDateLabel";
            this.publishDateLabel.Size = new System.Drawing.Size(99, 20);
            this.publishDateLabel.TabIndex = 13;
            this.publishDateLabel.Text = "Publish Date";
            // 
            // moviePublishDatePicker
            // 
            this.moviePublishDatePicker.Location = new System.Drawing.Point(33, 181);
            this.moviePublishDatePicker.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.moviePublishDatePicker.Name = "moviePublishDatePicker";
            this.moviePublishDatePicker.Size = new System.Drawing.Size(270, 26);
            this.moviePublishDatePicker.TabIndex = 3;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(345, 234);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(54, 20);
            this.genreLabel.TabIndex = 14;
            this.genreLabel.Text = "Genre";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(345, 158);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 20);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "Price";
            // 
            // copiesLabel
            // 
            this.copiesLabel.AutoSize = true;
            this.copiesLabel.Location = new System.Drawing.Point(439, 158);
            this.copiesLabel.Name = "copiesLabel";
            this.copiesLabel.Size = new System.Drawing.Size(58, 20);
            this.copiesLabel.TabIndex = 16;
            this.copiesLabel.Text = "Copies";
            // 
            // langaugesLabel
            // 
            this.langaugesLabel.AutoSize = true;
            this.langaugesLabel.Location = new System.Drawing.Point(36, 234);
            this.langaugesLabel.Name = "langaugesLabel";
            this.langaugesLabel.Size = new System.Drawing.Size(89, 20);
            this.langaugesLabel.TabIndex = 17;
            this.langaugesLabel.Text = "Languages";
            // 
            // copiesNumeric
            // 
            this.copiesNumeric.Location = new System.Drawing.Point(432, 184);
            this.copiesNumeric.Name = "copiesNumeric";
            this.copiesNumeric.Size = new System.Drawing.Size(86, 26);
            this.copiesNumeric.TabIndex = 18;
            // 
            // priceNumeric
            // 
            this.priceNumeric.DecimalPlaces = 2;
            this.priceNumeric.Location = new System.Drawing.Point(338, 184);
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(86, 26);
            this.priceNumeric.TabIndex = 19;
            // 
            // ageRatingDrop
            // 
            this.ageRatingDrop.DataSource = new Inchirieri_de_casete_video.AgeRating[] {
        Inchirieri_de_casete_video.AgeRating.G,
        Inchirieri_de_casete_video.AgeRating.PG,
        Inchirieri_de_casete_video.AgeRating.PG13,
        Inchirieri_de_casete_video.AgeRating.R,
        Inchirieri_de_casete_video.AgeRating.NC17};
            this.ageRatingDrop.FormattingEnabled = true;
            this.ageRatingDrop.Location = new System.Drawing.Point(338, 101);
            this.ageRatingDrop.Name = "ageRatingDrop";
            this.ageRatingDrop.Size = new System.Drawing.Size(179, 28);
            this.ageRatingDrop.TabIndex = 20;
            this.ageRatingDrop.SelectedIndexChanged += new System.EventHandler(this.ageRatingDrop_SelectedIndexChanged);
            // 
            // genreTB
            // 
            this.genreTB.Location = new System.Drawing.Point(338, 257);
            this.genreTB.Name = "genreTB";
            this.genreTB.Size = new System.Drawing.Size(179, 26);
            this.genreTB.TabIndex = 21;
            // 
            // langaugesTB
            // 
            this.langaugesTB.Location = new System.Drawing.Point(33, 257);
            this.langaugesTB.Multiline = true;
            this.langaugesTB.Name = "langaugesTB";
            this.langaugesTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.langaugesTB.Size = new System.Drawing.Size(268, 83);
            this.langaugesTB.TabIndex = 22;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(554, 430);
            this.Controls.Add(this.langaugesTB);
            this.Controls.Add(this.genreTB);
            this.Controls.Add(this.ageRatingDrop);
            this.Controls.Add(this.priceNumeric);
            this.Controls.Add(this.copiesNumeric);
            this.Controls.Add(this.langaugesLabel);
            this.Controls.Add(this.copiesLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.moviePublishDatePicker);
            this.Controls.Add(this.publishDateLabel);
            this.Controls.Add(this.ageRatingLabel);
            this.Controls.Add(this.movieNameTB);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addMovieBtn);
            this.Controls.Add(this.movieNameLabel);
            this.Controls.Add(this.barPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.barPanel.ResumeLayout(false);
            this.barPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copiesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label windowTitleLabel;
        private System.Windows.Forms.Panel barPanel;
        private System.Windows.Forms.Label movieNameLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addMovieBtn;
        private System.Windows.Forms.TextBox movieNameTB;
        private System.Windows.Forms.Label ageRatingLabel;
        private System.Windows.Forms.Label publishDateLabel;
        private System.Windows.Forms.DateTimePicker moviePublishDatePicker;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label copiesLabel;
        private System.Windows.Forms.Label langaugesLabel;
        private System.Windows.Forms.NumericUpDown copiesNumeric;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.Windows.Forms.ComboBox ageRatingDrop;
        private System.Windows.Forms.TextBox genreTB;
        private System.Windows.Forms.TextBox langaugesTB;
    }
}