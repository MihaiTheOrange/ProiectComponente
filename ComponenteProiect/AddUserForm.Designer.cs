namespace ComponenteProiect
{
    partial class AddUserForm
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
            this.CancelButton = new MetroFramework.Controls.MetroButton();
            this.AddButton = new MetroFramework.Controls.MetroButton();
            this.lBoxTelefon = new MetroFramework.Controls.MetroLabel();
            this.lBoxAdresa = new MetroFramework.Controls.MetroLabel();
            this.lBoxEmail = new MetroFramework.Controls.MetroLabel();
            this.lBoxPrenume = new MetroFramework.Controls.MetroLabel();
            this.lBoxNume = new MetroFramework.Controls.MetroLabel();
            this.Telefon = new MetroFramework.Controls.MetroTextBox();
            this.Adresa = new MetroFramework.Controls.MetroTextBox();
            this.Email = new MetroFramework.Controls.MetroTextBox();
            this.Prenume = new MetroFramework.Controls.MetroTextBox();
            this.Nume = new MetroFramework.Controls.MetroTextBox();
            this.GenM = new MetroFramework.Controls.MetroRadioButton();
            this.GenN = new MetroFramework.Controls.MetroRadioButton();
            this.GenF = new MetroFramework.Controls.MetroRadioButton();
            this.lBoxGen = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton.Location = new System.Drawing.Point(252, 354);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseCustomBackColor = true;
            this.CancelButton.UseSelectable = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddButton.Location = new System.Drawing.Point(171, 354);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseCustomBackColor = true;
            this.AddButton.UseSelectable = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // lBoxTelefon
            // 
            this.lBoxTelefon.AutoSize = true;
            this.lBoxTelefon.ForeColor = System.Drawing.Color.Black;
            this.lBoxTelefon.Location = new System.Drawing.Point(16, 185);
            this.lBoxTelefon.Name = "lBoxTelefon";
            this.lBoxTelefon.Size = new System.Drawing.Size(50, 19);
            this.lBoxTelefon.TabIndex = 47;
            this.lBoxTelefon.Text = "Telefon";
            this.lBoxTelefon.UseCustomForeColor = true;
            // 
            // lBoxAdresa
            // 
            this.lBoxAdresa.AutoSize = true;
            this.lBoxAdresa.ForeColor = System.Drawing.Color.Black;
            this.lBoxAdresa.Location = new System.Drawing.Point(16, 157);
            this.lBoxAdresa.Name = "lBoxAdresa";
            this.lBoxAdresa.Size = new System.Drawing.Size(50, 19);
            this.lBoxAdresa.TabIndex = 46;
            this.lBoxAdresa.Text = "Adresa";
            this.lBoxAdresa.UseCustomForeColor = true;
            // 
            // lBoxEmail
            // 
            this.lBoxEmail.AutoSize = true;
            this.lBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.lBoxEmail.Location = new System.Drawing.Point(16, 129);
            this.lBoxEmail.Name = "lBoxEmail";
            this.lBoxEmail.Size = new System.Drawing.Size(41, 19);
            this.lBoxEmail.TabIndex = 45;
            this.lBoxEmail.Text = "Email";
            this.lBoxEmail.UseCustomForeColor = true;
            // 
            // lBoxPrenume
            // 
            this.lBoxPrenume.AutoSize = true;
            this.lBoxPrenume.ForeColor = System.Drawing.Color.Black;
            this.lBoxPrenume.Location = new System.Drawing.Point(16, 95);
            this.lBoxPrenume.Name = "lBoxPrenume";
            this.lBoxPrenume.Size = new System.Drawing.Size(62, 19);
            this.lBoxPrenume.TabIndex = 43;
            this.lBoxPrenume.Text = "Prenume";
            this.lBoxPrenume.UseCustomForeColor = true;
            // 
            // lBoxNume
            // 
            this.lBoxNume.AutoSize = true;
            this.lBoxNume.ForeColor = System.Drawing.Color.Black;
            this.lBoxNume.Location = new System.Drawing.Point(16, 67);
            this.lBoxNume.Name = "lBoxNume";
            this.lBoxNume.Size = new System.Drawing.Size(45, 19);
            this.lBoxNume.TabIndex = 42;
            this.lBoxNume.Text = "Nume";
            this.lBoxNume.UseCustomForeColor = true;
            // 
            // Telefon
            // 
            // 
            // 
            // 
            this.Telefon.CustomButton.Image = null;
            this.Telefon.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Telefon.CustomButton.Name = "";
            this.Telefon.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Telefon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Telefon.CustomButton.TabIndex = 1;
            this.Telefon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Telefon.CustomButton.UseSelectable = true;
            this.Telefon.CustomButton.Visible = false;
            this.Telefon.Lines = new string[0];
            this.Telefon.Location = new System.Drawing.Point(80, 185);
            this.Telefon.MaxLength = 32767;
            this.Telefon.Name = "Telefon";
            this.Telefon.PasswordChar = '\0';
            this.Telefon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Telefon.SelectedText = "";
            this.Telefon.SelectionLength = 0;
            this.Telefon.SelectionStart = 0;
            this.Telefon.ShortcutsEnabled = true;
            this.Telefon.Size = new System.Drawing.Size(100, 19);
            this.Telefon.TabIndex = 41;
            this.Telefon.UseSelectable = true;
            this.Telefon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Telefon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Telefon.TextChanged += new System.EventHandler(this.Telefon_TextChanged);
            
            // 
            // Adresa
            // 
            // 
            // 
            // 
            this.Adresa.CustomButton.Image = null;
            this.Adresa.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Adresa.CustomButton.Name = "";
            this.Adresa.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Adresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Adresa.CustomButton.TabIndex = 1;
            this.Adresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Adresa.CustomButton.UseSelectable = true;
            this.Adresa.CustomButton.Visible = false;
            this.Adresa.Lines = new string[0];
            this.Adresa.Location = new System.Drawing.Point(80, 157);
            this.Adresa.MaxLength = 32767;
            this.Adresa.Name = "Adresa";
            this.Adresa.PasswordChar = '\0';
            this.Adresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Adresa.SelectedText = "";
            this.Adresa.SelectionLength = 0;
            this.Adresa.SelectionStart = 0;
            this.Adresa.ShortcutsEnabled = true;
            this.Adresa.Size = new System.Drawing.Size(100, 19);
            this.Adresa.TabIndex = 40;
            this.Adresa.UseSelectable = true;
            this.Adresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Adresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Adresa.TextChanged += new System.EventHandler(this.Adresa_TextChanged);
            // 
            // Email
            // 
            // 
            // 
            // 
            this.Email.CustomButton.Image = null;
            this.Email.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Email.CustomButton.Name = "";
            this.Email.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Email.CustomButton.TabIndex = 1;
            this.Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Email.CustomButton.UseSelectable = true;
            this.Email.CustomButton.Visible = false;
            this.Email.Lines = new string[0];
            this.Email.Location = new System.Drawing.Point(80, 129);
            this.Email.MaxLength = 32767;
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Email.SelectedText = "";
            this.Email.SelectionLength = 0;
            this.Email.SelectionStart = 0;
            this.Email.ShortcutsEnabled = true;
            this.Email.Size = new System.Drawing.Size(100, 19);
            this.Email.TabIndex = 39;
            this.Email.UseSelectable = true;
            this.Email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Prenume
            // 
            // 
            // 
            // 
            this.Prenume.CustomButton.Image = null;
            this.Prenume.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Prenume.CustomButton.Name = "";
            this.Prenume.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Prenume.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Prenume.CustomButton.TabIndex = 1;
            this.Prenume.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prenume.CustomButton.UseSelectable = true;
            this.Prenume.CustomButton.Visible = false;
            this.Prenume.Lines = new string[0];
            this.Prenume.Location = new System.Drawing.Point(80, 95);
            this.Prenume.MaxLength = 32767;
            this.Prenume.Name = "Prenume";
            this.Prenume.PasswordChar = '\0';
            this.Prenume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Prenume.SelectedText = "";
            this.Prenume.SelectionLength = 0;
            this.Prenume.SelectionStart = 0;
            this.Prenume.ShortcutsEnabled = true;
            this.Prenume.Size = new System.Drawing.Size(100, 19);
            this.Prenume.TabIndex = 37;
            this.Prenume.UseSelectable = true;
            this.Prenume.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Prenume.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Prenume.TextChanged += new System.EventHandler(this.Prenume_TextChanged);
            // 
            // Nume
            // 
            // 
            // 
            // 
            this.Nume.CustomButton.Image = null;
            this.Nume.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Nume.CustomButton.Name = "";
            this.Nume.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Nume.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Nume.CustomButton.TabIndex = 1;
            this.Nume.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Nume.CustomButton.UseSelectable = true;
            this.Nume.CustomButton.Visible = false;
            this.Nume.Lines = new string[0];
            this.Nume.Location = new System.Drawing.Point(80, 67);
            this.Nume.MaxLength = 32767;
            this.Nume.Name = "Nume";
            this.Nume.PasswordChar = '\0';
            this.Nume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Nume.SelectedText = "";
            this.Nume.SelectionLength = 0;
            this.Nume.SelectionStart = 0;
            this.Nume.ShortcutsEnabled = true;
            this.Nume.Size = new System.Drawing.Size(100, 19);
            this.Nume.TabIndex = 36;
            this.Nume.UseSelectable = true;
            this.Nume.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Nume.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Nume.TextChanged += new System.EventHandler(this.Nume_TextChanged);
            // 
            // GenM
            // 
            this.GenM.AutoSize = true;
            this.GenM.Location = new System.Drawing.Point(77, 219);
            this.GenM.Name = "GenM";
            this.GenM.Size = new System.Drawing.Size(34, 15);
            this.GenM.TabIndex = 49;
            this.GenM.Text = "M";
            this.GenM.UseSelectable = true;
            // 
            // GenN
            // 
            this.GenN.AutoSize = true;
            this.GenN.Location = new System.Drawing.Point(152, 219);
            this.GenN.Name = "GenN";
            this.GenN.Size = new System.Drawing.Size(32, 15);
            this.GenN.TabIndex = 50;
            this.GenN.Text = "N";
            this.GenN.UseSelectable = true;
            // 
            // GenF
            // 
            this.GenF.AutoSize = true;
            this.GenF.Location = new System.Drawing.Point(117, 219);
            this.GenF.Name = "GenF";
            this.GenF.Size = new System.Drawing.Size(29, 15);
            this.GenF.TabIndex = 51;
            this.GenF.Text = "F";
            this.GenF.UseCustomForeColor = true;
            this.GenF.UseSelectable = true;
            // 
            // lBoxGen
            // 
            this.lBoxGen.AutoSize = true;
            this.lBoxGen.ForeColor = System.Drawing.Color.Black;
            this.lBoxGen.Location = new System.Drawing.Point(16, 215);
            this.lBoxGen.Name = "lBoxGen";
            this.lBoxGen.Size = new System.Drawing.Size(32, 19);
            this.lBoxGen.TabIndex = 52;
            this.lBoxGen.Text = "Gen";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.lBoxGen);
            this.Controls.Add(this.GenF);
            this.Controls.Add(this.GenN);
            this.Controls.Add(this.GenM);
            this.Controls.Add(this.lBoxTelefon);
            this.Controls.Add(this.lBoxAdresa);
            this.Controls.Add(this.lBoxEmail);
            this.Controls.Add(this.lBoxPrenume);
            this.Controls.Add(this.lBoxNume);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "AddUserForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton CancelButton;
        private MetroFramework.Controls.MetroButton AddButton;
        private MetroFramework.Controls.MetroLabel lBoxTelefon;
        private MetroFramework.Controls.MetroLabel lBoxAdresa;
        private MetroFramework.Controls.MetroLabel lBoxEmail;
        private MetroFramework.Controls.MetroLabel lBoxPrenume;
        private MetroFramework.Controls.MetroLabel lBoxNume;
        private MetroFramework.Controls.MetroTextBox Telefon;
        private MetroFramework.Controls.MetroTextBox Adresa;
        private MetroFramework.Controls.MetroTextBox Email;
        private MetroFramework.Controls.MetroTextBox Prenume;
        private MetroFramework.Controls.MetroTextBox Nume;
        private MetroFramework.Controls.MetroRadioButton GenM;
        private MetroFramework.Controls.MetroRadioButton GenN;
        private MetroFramework.Controls.MetroRadioButton GenF;
        private MetroFramework.Controls.MetroLabel lBoxGen;
    }
}