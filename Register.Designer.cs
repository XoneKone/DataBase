namespace DataBase
{
    partial class Register_сlient
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
            this.FIO_client = new System.Windows.Forms.RichTextBox();
            this.Birthdate_client = new System.Windows.Forms.RichTextBox();
            this.Mob_phone_client = new System.Windows.Forms.RichTextBox();
            this.Adress_client = new System.Windows.Forms.RichTextBox();
            this.gender_client = new System.Windows.Forms.RichTextBox();
            this.wages_clients = new System.Windows.Forms.RichTextBox();
            this.Data_agr = new System.Windows.Forms.RichTextBox();
            this.Contracter = new System.Windows.Forms.ComboBox();
            this.type_loan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FIO_client
            // 
            this.FIO_client.Location = new System.Drawing.Point(219, 28);
            this.FIO_client.Name = "FIO_client";
            this.FIO_client.Size = new System.Drawing.Size(336, 24);
            this.FIO_client.TabIndex = 0;
            this.FIO_client.Text = "";
            // 
            // Birthdate_client
            // 
            this.Birthdate_client.Location = new System.Drawing.Point(219, 67);
            this.Birthdate_client.Name = "Birthdate_client";
            this.Birthdate_client.Size = new System.Drawing.Size(55, 21);
            this.Birthdate_client.TabIndex = 1;
            this.Birthdate_client.Text = "";
            // 
            // Mob_phone_client
            // 
            this.Mob_phone_client.Location = new System.Drawing.Point(219, 146);
            this.Mob_phone_client.Name = "Mob_phone_client";
            this.Mob_phone_client.Size = new System.Drawing.Size(113, 20);
            this.Mob_phone_client.TabIndex = 2;
            this.Mob_phone_client.Text = "";
            // 
            // Adress_client
            // 
            this.Adress_client.Location = new System.Drawing.Point(219, 183);
            this.Adress_client.Name = "Adress_client";
            this.Adress_client.Size = new System.Drawing.Size(336, 41);
            this.Adress_client.TabIndex = 3;
            this.Adress_client.Text = "";
            // 
            // gender_client
            // 
            this.gender_client.Location = new System.Drawing.Point(219, 105);
            this.gender_client.Name = "gender_client";
            this.gender_client.Size = new System.Drawing.Size(55, 24);
            this.gender_client.TabIndex = 4;
            this.gender_client.Text = "";
            // 
            // wages_clients
            // 
            this.wages_clients.Location = new System.Drawing.Point(219, 400);
            this.wages_clients.Name = "wages_clients";
            this.wages_clients.Size = new System.Drawing.Size(113, 24);
            this.wages_clients.TabIndex = 5;
            this.wages_clients.Text = "";
            // 
            // Data_agr
            // 
            this.Data_agr.Location = new System.Drawing.Point(219, 355);
            this.Data_agr.Name = "Data_agr";
            this.Data_agr.Size = new System.Drawing.Size(55, 24);
            this.Data_agr.TabIndex = 6;
            this.Data_agr.Text = "";
            // 
            // Contracter
            // 
            this.Contracter.FormattingEnabled = true;
            this.Contracter.Location = new System.Drawing.Point(219, 248);
            this.Contracter.Name = "Contracter";
            this.Contracter.Size = new System.Drawing.Size(121, 21);
            this.Contracter.TabIndex = 7;
            // 
            // type_loan
            // 
            this.type_loan.FormattingEnabled = true;
            this.type_loan.Location = new System.Drawing.Point(219, 293);
            this.type_loan.Name = "type_loan";
            this.type_loan.Size = new System.Drawing.Size(121, 21);
            this.type_loan.TabIndex = 8;
            // 
            // Register_сlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 504);
            this.Controls.Add(this.type_loan);
            this.Controls.Add(this.Contracter);
            this.Controls.Add(this.Data_agr);
            this.Controls.Add(this.wages_clients);
            this.Controls.Add(this.gender_client);
            this.Controls.Add(this.Adress_client);
            this.Controls.Add(this.Mob_phone_client);
            this.Controls.Add(this.Birthdate_client);
            this.Controls.Add(this.FIO_client);
            this.Name = "Register_сlient";
            this.Text = "Добавление клиента";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox FIO_client;
        private System.Windows.Forms.RichTextBox Birthdate_client;
        private System.Windows.Forms.RichTextBox Mob_phone_client;
        private System.Windows.Forms.RichTextBox Adress_client;
        private System.Windows.Forms.RichTextBox gender_client;
        private System.Windows.Forms.RichTextBox wages_clients;
        private System.Windows.Forms.RichTextBox Data_agr;
        private System.Windows.Forms.ComboBox Contracter;
        private System.Windows.Forms.ComboBox type_loan;
    }
}