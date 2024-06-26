﻿using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inchirieri_de_casete_video
{
    public partial class AddClient : Form
    {
        
        
        public AddClient()
        {
            InitializeComponent();
        }

        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addClientBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.clientNameTB = new System.Windows.Forms.TextBox();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.barPanel = new System.Windows.Forms.Panel();
            this.windowTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientSurnameTB = new System.Windows.Forms.TextBox();
            this.barPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addClientBtn
            // 
            this.addClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientBtn.Location = new System.Drawing.Point(157, 245);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(100, 28);
            this.addClientBtn.TabIndex = 0;
            this.addClientBtn.Text = "Add";
            this.addClientBtn.UseVisualStyleBackColor = true;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(282, 245);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nameLabel.Location = new System.Drawing.Point(20, 76);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(95, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Client Name";
            // 
            // birthdayDatePicker
            // 
            this.birthdayDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayDatePicker.CustomFormat = "DD-MM-YYYY";
            this.birthdayDatePicker.Location = new System.Drawing.Point(305, 184);
            this.birthdayDatePicker.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.birthdayDatePicker.Name = "birthdayDatePicker";
            this.birthdayDatePicker.Size = new System.Drawing.Size(193, 20);
            this.birthdayDatePicker.TabIndex = 3;
            this.birthdayDatePicker.Value = new System.DateTime(2024, 3, 28, 0, 0, 0, 0);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.birthdayLabel.Location = new System.Drawing.Point(301, 155);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(67, 20);
            this.birthdayLabel.TabIndex = 4;
            this.birthdayLabel.Text = "Birthday";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.adressLabel.Location = new System.Drawing.Point(20, 155);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(59, 20);
            this.adressLabel.TabIndex = 5;
            this.adressLabel.Text = "Adress";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.phoneLabel.Location = new System.Drawing.Point(301, 76);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(113, 20);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone number";
            // 
            // clientNameTB
            // 
            this.clientNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameTB.Location = new System.Drawing.Point(24, 99);
            this.clientNameTB.Name = "clientNameTB";
            this.clientNameTB.Size = new System.Drawing.Size(115, 26);
            this.clientNameTB.TabIndex = 7;
            // 
            // adressTB
            // 
            this.adressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressTB.Location = new System.Drawing.Point(24, 178);
            this.adressTB.Name = "adressTB";
            this.adressTB.Size = new System.Drawing.Size(247, 26);
            this.adressTB.TabIndex = 8;
            // 
            // phoneTB
            // 
            this.phoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTB.Location = new System.Drawing.Point(305, 99);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(193, 26);
            this.phoneTB.TabIndex = 9;
            // 
            // barPanel
            // 
            this.barPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.barPanel.Controls.Add(this.windowTitleLabel);
            this.barPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.barPanel.Location = new System.Drawing.Point(1, 0);
            this.barPanel.Name = "barPanel";
            this.barPanel.Size = new System.Drawing.Size(519, 41);
            this.barPanel.TabIndex = 10;
            // 
            // windowTitleLabel
            // 
            this.windowTitleLabel.AutoSize = true;
            this.windowTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitleLabel.Location = new System.Drawing.Point(11, 9);
            this.windowTitleLabel.Name = "windowTitleLabel";
            this.windowTitleLabel.Size = new System.Drawing.Size(107, 25);
            this.windowTitleLabel.TabIndex = 0;
            this.windowTitleLabel.Text = "Add client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(141, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Client Surname";
            // 
            // clientSurnameTB
            // 
            this.clientSurnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientSurnameTB.Location = new System.Drawing.Point(145, 99);
            this.clientSurnameTB.Name = "clientSurnameTB";
            this.clientSurnameTB.Size = new System.Drawing.Size(126, 26);
            this.clientSurnameTB.TabIndex = 12;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(519, 305);
            this.Controls.Add(this.clientSurnameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barPanel);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.clientNameTB);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.birthdayDatePicker);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addClientBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.barPanel.ResumeLayout(false);
            this.barPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addClientBtn;
        private Button cancelBtn;
        private Label nameLabel;
        private DateTimePicker birthdayDatePicker;
        private Label birthdayLabel;
        private Label adressLabel;
        private Label phoneLabel;
        private TextBox clientNameTB;
        private TextBox adressTB;
        private TextBox phoneTB;
        private Panel barPanel;
        private Label windowTitleLabel;
        private Label label1;
        private TextBox clientSurnameTB;
    }
}