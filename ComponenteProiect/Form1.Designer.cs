using MetroFramework.Controls;
using System.Drawing;

namespace ComponenteProiect
{
    partial class Form1
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
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.Denumire = new MetroFramework.Controls.MetroTextBox();
            this.Producator = new MetroFramework.Controls.MetroTextBox();
            this.CPU = new MetroFramework.Controls.MetroTextBox();
            this.Producator_GPU = new MetroFramework.Controls.MetroTextBox();
            this.GPU = new MetroFramework.Controls.MetroTextBox();
            this.RAM = new MetroFramework.Controls.MetroTextBox();
            this.Stocare = new MetroFramework.Controls.MetroTextBox();
            this.Carcasa = new MetroFramework.Controls.MetroTextBox();
            this.Front_Panel = new MetroFramework.Controls.MetroTextBox();
            this.Sursa = new MetroFramework.Controls.MetroTextBox();
            this.Nume = new MetroFramework.Controls.MetroTextBox();
            this.Prenume = new MetroFramework.Controls.MetroTextBox();
            this.Gen = new MetroFramework.Controls.MetroTextBox();
            this.Email = new MetroFramework.Controls.MetroTextBox();
            this.Adresa = new MetroFramework.Controls.MetroTextBox();
            this.Telefon = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.lBoxDenumire = new MetroFramework.Controls.MetroLabel();
            this.lBoxProducator = new MetroFramework.Controls.MetroLabel();
            this.lBoxCPU = new MetroFramework.Controls.MetroLabel();
            this.lBoxProducator_GPU = new MetroFramework.Controls.MetroLabel();
            this.lBoxGPU = new MetroFramework.Controls.MetroLabel();
            this.lBoxRAM = new MetroFramework.Controls.MetroLabel();
            this.lBoxStocare = new MetroFramework.Controls.MetroLabel();
            this.lBoxCarcasa = new MetroFramework.Controls.MetroLabel();
            this.lBoxFront_Panel = new MetroFramework.Controls.MetroLabel();
            this.lBoxSursa = new MetroFramework.Controls.MetroLabel();
            this.lBoxNume = new MetroFramework.Controls.MetroLabel();
            this.lBoxPrenume = new MetroFramework.Controls.MetroLabel();
            this.lBoxGen = new MetroFramework.Controls.MetroLabel();
            this.lBoxEmail = new MetroFramework.Controls.MetroLabel();
            this.lBoxAdresa = new MetroFramework.Controls.MetroLabel();
            this.lBoxTelefon = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(821, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adauga Calculator:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(1048, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adauga Utilizator:";
            // 
            // Denumire
            // 
            // 
            // 
            // 
            this.Denumire.CustomButton.Image = null;
            this.Denumire.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Denumire.CustomButton.Name = "";
            this.Denumire.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Denumire.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Denumire.CustomButton.TabIndex = 1;
            this.Denumire.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Denumire.CustomButton.UseSelectable = true;
            this.Denumire.CustomButton.Visible = false;
            this.Denumire.Lines = new string[0];
            this.Denumire.Location = new System.Drawing.Point(846, 91);
            this.Denumire.MaxLength = 32767;
            this.Denumire.Name = "Denumire";
            this.Denumire.PasswordChar = '\0';
            this.Denumire.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Denumire.SelectedText = "";
            this.Denumire.SelectionLength = 0;
            this.Denumire.SelectionStart = 0;
            this.Denumire.ShortcutsEnabled = true;
            this.Denumire.Size = new System.Drawing.Size(100, 19);
            this.Denumire.TabIndex = 2;
            this.Denumire.UseSelectable = true;
            this.Denumire.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Denumire.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Denumire.TextChanged += new System.EventHandler(this.Denumire_TextChanged);
            // 
            // Producator
            // 
            // 
            // 
            // 
            this.Producator.CustomButton.Image = null;
            this.Producator.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Producator.CustomButton.Name = "";
            this.Producator.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Producator.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Producator.CustomButton.TabIndex = 1;
            this.Producator.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Producator.CustomButton.UseSelectable = true;
            this.Producator.CustomButton.Visible = false;
            this.Producator.Lines = new string[0];
            this.Producator.Location = new System.Drawing.Point(846, 119);
            this.Producator.MaxLength = 32767;
            this.Producator.Name = "Producator";
            this.Producator.PasswordChar = '\0';
            this.Producator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Producator.SelectedText = "";
            this.Producator.SelectionLength = 0;
            this.Producator.SelectionStart = 0;
            this.Producator.ShortcutsEnabled = true;
            this.Producator.Size = new System.Drawing.Size(100, 19);
            this.Producator.TabIndex = 3;
            this.Producator.UseSelectable = true;
            this.Producator.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Producator.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Producator.TextChanged += new System.EventHandler(this.Producator_TextChanged);
            this.Producator.Click += new System.EventHandler(this.Producator_Click);
            // 
            // CPU
            // 
            // 
            // 
            // 
            this.CPU.CustomButton.Image = null;
            this.CPU.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.CPU.CustomButton.Name = "";
            this.CPU.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.CPU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CPU.CustomButton.TabIndex = 1;
            this.CPU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CPU.CustomButton.UseSelectable = true;
            this.CPU.CustomButton.Visible = false;
            this.CPU.Lines = new string[0];
            this.CPU.Location = new System.Drawing.Point(846, 147);
            this.CPU.MaxLength = 32767;
            this.CPU.Name = "CPU";
            this.CPU.PasswordChar = '\0';
            this.CPU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CPU.SelectedText = "";
            this.CPU.SelectionLength = 0;
            this.CPU.SelectionStart = 0;
            this.CPU.ShortcutsEnabled = true;
            this.CPU.Size = new System.Drawing.Size(100, 19);
            this.CPU.TabIndex = 4;
            this.CPU.UseSelectable = true;
            this.CPU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CPU.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CPU.TextChanged += new System.EventHandler(this.CPU_TextChanged);
            // 
            // Producator_GPU
            // 
            // 
            // 
            // 
            this.Producator_GPU.CustomButton.Image = null;
            this.Producator_GPU.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Producator_GPU.CustomButton.Name = "";
            this.Producator_GPU.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Producator_GPU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Producator_GPU.CustomButton.TabIndex = 1;
            this.Producator_GPU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Producator_GPU.CustomButton.UseSelectable = true;
            this.Producator_GPU.CustomButton.Visible = false;
            this.Producator_GPU.Lines = new string[0];
            this.Producator_GPU.Location = new System.Drawing.Point(846, 175);
            this.Producator_GPU.MaxLength = 32767;
            this.Producator_GPU.Name = "Producator_GPU";
            this.Producator_GPU.PasswordChar = '\0';
            this.Producator_GPU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Producator_GPU.SelectedText = "";
            this.Producator_GPU.SelectionLength = 0;
            this.Producator_GPU.SelectionStart = 0;
            this.Producator_GPU.ShortcutsEnabled = true;
            this.Producator_GPU.Size = new System.Drawing.Size(100, 19);
            this.Producator_GPU.TabIndex = 5;
            this.Producator_GPU.UseSelectable = true;
            this.Producator_GPU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Producator_GPU.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Producator_GPU.TextChanged += new System.EventHandler(this.Producator_GPU_TextChanged);
            // 
            // GPU
            // 
            // 
            // 
            // 
            this.GPU.CustomButton.Image = null;
            this.GPU.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.GPU.CustomButton.Name = "";
            this.GPU.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.GPU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.GPU.CustomButton.TabIndex = 1;
            this.GPU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GPU.CustomButton.UseSelectable = true;
            this.GPU.CustomButton.Visible = false;
            this.GPU.Lines = new string[0];
            this.GPU.Location = new System.Drawing.Point(846, 203);
            this.GPU.MaxLength = 32767;
            this.GPU.Name = "GPU";
            this.GPU.PasswordChar = '\0';
            this.GPU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GPU.SelectedText = "";
            this.GPU.SelectionLength = 0;
            this.GPU.SelectionStart = 0;
            this.GPU.ShortcutsEnabled = true;
            this.GPU.Size = new System.Drawing.Size(100, 19);
            this.GPU.TabIndex = 6;
            this.GPU.UseSelectable = true;
            this.GPU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GPU.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.GPU.TextChanged += new System.EventHandler(this.GPU_TextChanged);
            // 
            // RAM
            // 
            // 
            // 
            // 
            this.RAM.CustomButton.Image = null;
            this.RAM.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.RAM.CustomButton.Name = "";
            this.RAM.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.RAM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RAM.CustomButton.TabIndex = 1;
            this.RAM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RAM.CustomButton.UseSelectable = true;
            this.RAM.CustomButton.Visible = false;
            this.RAM.Lines = new string[0];
            this.RAM.Location = new System.Drawing.Point(846, 231);
            this.RAM.MaxLength = 32767;
            this.RAM.Name = "RAM";
            this.RAM.PasswordChar = '\0';
            this.RAM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RAM.SelectedText = "";
            this.RAM.SelectionLength = 0;
            this.RAM.SelectionStart = 0;
            this.RAM.ShortcutsEnabled = true;
            this.RAM.Size = new System.Drawing.Size(100, 19);
            this.RAM.TabIndex = 7;
            this.RAM.UseSelectable = true;
            this.RAM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RAM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.RAM.TextChanged += new System.EventHandler(this.RAM_TextChanged);
            // 
            // Stocare
            // 
            // 
            // 
            // 
            this.Stocare.CustomButton.Image = null;
            this.Stocare.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Stocare.CustomButton.Name = "";
            this.Stocare.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Stocare.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Stocare.CustomButton.TabIndex = 1;
            this.Stocare.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Stocare.CustomButton.UseSelectable = true;
            this.Stocare.CustomButton.Visible = false;
            this.Stocare.Lines = new string[0];
            this.Stocare.Location = new System.Drawing.Point(846, 259);
            this.Stocare.MaxLength = 32767;
            this.Stocare.Name = "Stocare";
            this.Stocare.PasswordChar = '\0';
            this.Stocare.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Stocare.SelectedText = "";
            this.Stocare.SelectionLength = 0;
            this.Stocare.SelectionStart = 0;
            this.Stocare.ShortcutsEnabled = true;
            this.Stocare.Size = new System.Drawing.Size(100, 19);
            this.Stocare.TabIndex = 8;
            this.Stocare.UseSelectable = true;
            this.Stocare.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Stocare.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Stocare.TextChanged += new System.EventHandler(this.Stocare_TextChanged);
            // 
            // Carcasa
            // 
            // 
            // 
            // 
            this.Carcasa.CustomButton.Image = null;
            this.Carcasa.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Carcasa.CustomButton.Name = "";
            this.Carcasa.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Carcasa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Carcasa.CustomButton.TabIndex = 1;
            this.Carcasa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Carcasa.CustomButton.UseSelectable = true;
            this.Carcasa.CustomButton.Visible = false;
            this.Carcasa.Lines = new string[0];
            this.Carcasa.Location = new System.Drawing.Point(846, 287);
            this.Carcasa.MaxLength = 32767;
            this.Carcasa.Name = "Carcasa";
            this.Carcasa.PasswordChar = '\0';
            this.Carcasa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Carcasa.SelectedText = "";
            this.Carcasa.SelectionLength = 0;
            this.Carcasa.SelectionStart = 0;
            this.Carcasa.ShortcutsEnabled = true;
            this.Carcasa.Size = new System.Drawing.Size(100, 19);
            this.Carcasa.TabIndex = 9;
            this.Carcasa.UseSelectable = true;
            this.Carcasa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Carcasa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Carcasa.TextChanged += new System.EventHandler(this.Carcasa_TextChanged);
            // 
            // Front_Panel
            // 
            // 
            // 
            // 
            this.Front_Panel.CustomButton.Image = null;
            this.Front_Panel.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Front_Panel.CustomButton.Name = "";
            this.Front_Panel.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Front_Panel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Front_Panel.CustomButton.TabIndex = 1;
            this.Front_Panel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Front_Panel.CustomButton.UseSelectable = true;
            this.Front_Panel.CustomButton.Visible = false;
            this.Front_Panel.Lines = new string[0];
            this.Front_Panel.Location = new System.Drawing.Point(846, 315);
            this.Front_Panel.MaxLength = 32767;
            this.Front_Panel.Name = "Front_Panel";
            this.Front_Panel.PasswordChar = '\0';
            this.Front_Panel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Front_Panel.SelectedText = "";
            this.Front_Panel.SelectionLength = 0;
            this.Front_Panel.SelectionStart = 0;
            this.Front_Panel.ShortcutsEnabled = true;
            this.Front_Panel.Size = new System.Drawing.Size(100, 19);
            this.Front_Panel.TabIndex = 10;
            this.Front_Panel.UseSelectable = true;
            this.Front_Panel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Front_Panel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Front_Panel.TextChanged += new System.EventHandler(this.Front_Panel_TextChanged);
            // 
            // Sursa
            // 
            // 
            // 
            // 
            this.Sursa.CustomButton.Image = null;
            this.Sursa.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Sursa.CustomButton.Name = "";
            this.Sursa.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Sursa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Sursa.CustomButton.TabIndex = 1;
            this.Sursa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Sursa.CustomButton.UseSelectable = true;
            this.Sursa.CustomButton.Visible = false;
            this.Sursa.Lines = new string[0];
            this.Sursa.Location = new System.Drawing.Point(846, 343);
            this.Sursa.MaxLength = 32767;
            this.Sursa.Name = "Sursa";
            this.Sursa.PasswordChar = '\0';
            this.Sursa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Sursa.SelectedText = "";
            this.Sursa.SelectionLength = 0;
            this.Sursa.SelectionStart = 0;
            this.Sursa.ShortcutsEnabled = true;
            this.Sursa.Size = new System.Drawing.Size(100, 19);
            this.Sursa.TabIndex = 11;
            this.Sursa.UseSelectable = true;
            this.Sursa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Sursa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Sursa.TextChanged += new System.EventHandler(this.Sursa_TextChanged);
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
            this.Nume.Location = new System.Drawing.Point(1048, 91);
            this.Nume.MaxLength = 32767;
            this.Nume.Name = "Nume";
            this.Nume.PasswordChar = '\0';
            this.Nume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Nume.SelectedText = "";
            this.Nume.SelectionLength = 0;
            this.Nume.SelectionStart = 0;
            this.Nume.ShortcutsEnabled = true;
            this.Nume.Size = new System.Drawing.Size(100, 19);
            this.Nume.TabIndex = 12;
            this.Nume.UseSelectable = true;
            this.Nume.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Nume.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Nume.TextChanged += new System.EventHandler(this.Nume_TextChanged);
            this.Nume.Click += new System.EventHandler(this.Nume_Click);
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
            this.Prenume.Location = new System.Drawing.Point(1048, 119);
            this.Prenume.MaxLength = 32767;
            this.Prenume.Name = "Prenume";
            this.Prenume.PasswordChar = '\0';
            this.Prenume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Prenume.SelectedText = "";
            this.Prenume.SelectionLength = 0;
            this.Prenume.SelectionStart = 0;
            this.Prenume.ShortcutsEnabled = true;
            this.Prenume.Size = new System.Drawing.Size(100, 19);
            this.Prenume.TabIndex = 13;
            this.Prenume.UseSelectable = true;
            this.Prenume.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Prenume.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Prenume.TextChanged += new System.EventHandler(this.Prenume_TextChanged);
            // 
            // Gen
            // 
            // 
            // 
            // 
            this.Gen.CustomButton.Image = null;
            this.Gen.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.Gen.CustomButton.Name = "";
            this.Gen.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.Gen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Gen.CustomButton.TabIndex = 1;
            this.Gen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Gen.CustomButton.UseSelectable = true;
            this.Gen.CustomButton.Visible = false;
            this.Gen.Lines = new string[0];
            this.Gen.Location = new System.Drawing.Point(1048, 147);
            this.Gen.MaxLength = 32767;
            this.Gen.Name = "Gen";
            this.Gen.PasswordChar = '\0';
            this.Gen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Gen.SelectedText = "";
            this.Gen.SelectionLength = 0;
            this.Gen.SelectionStart = 0;
            this.Gen.ShortcutsEnabled = true;
            this.Gen.Size = new System.Drawing.Size(100, 19);
            this.Gen.TabIndex = 14;
            this.Gen.UseSelectable = true;
            this.Gen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Gen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Gen.TextChanged += new System.EventHandler(this.Gen_TextChanged);
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
            this.Email.Location = new System.Drawing.Point(1048, 175);
            this.Email.MaxLength = 32767;
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Email.SelectedText = "";
            this.Email.SelectionLength = 0;
            this.Email.SelectionStart = 0;
            this.Email.ShortcutsEnabled = true;
            this.Email.Size = new System.Drawing.Size(100, 19);
            this.Email.TabIndex = 15;
            this.Email.UseSelectable = true;
            this.Email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
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
            this.Adresa.Location = new System.Drawing.Point(1048, 203);
            this.Adresa.MaxLength = 32767;
            this.Adresa.Name = "Adresa";
            this.Adresa.PasswordChar = '\0';
            this.Adresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Adresa.SelectedText = "";
            this.Adresa.SelectionLength = 0;
            this.Adresa.SelectionStart = 0;
            this.Adresa.ShortcutsEnabled = true;
            this.Adresa.Size = new System.Drawing.Size(100, 19);
            this.Adresa.TabIndex = 16;
            this.Adresa.UseSelectable = true;
            this.Adresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Adresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Adresa.TextChanged += new System.EventHandler(this.Adresa_TextChanged);
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
            this.Telefon.Location = new System.Drawing.Point(1048, 231);
            this.Telefon.MaxLength = 32767;
            this.Telefon.Name = "Telefon";
            this.Telefon.PasswordChar = '\0';
            this.Telefon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Telefon.SelectedText = "";
            this.Telefon.SelectionLength = 0;
            this.Telefon.SelectionStart = 0;
            this.Telefon.ShortcutsEnabled = true;
            this.Telefon.Size = new System.Drawing.Size(100, 19);
            this.Telefon.TabIndex = 17;
            this.Telefon.UseSelectable = true;
            this.Telefon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Telefon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Telefon.TextChanged += new System.EventHandler(this.Telefon_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(846, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1048, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 24);
            this.button2.TabIndex = 19;
            this.button2.Text = "Add";
            this.button2.UseSelectable = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lBoxDenumire
            // 
            this.lBoxDenumire.AutoSize = true;
            this.lBoxDenumire.ForeColor = System.Drawing.Color.Black;
            this.lBoxDenumire.Location = new System.Drawing.Point(781, 91);
            this.lBoxDenumire.Name = "lBoxDenumire";
            this.lBoxDenumire.Size = new System.Drawing.Size(66, 19);
            this.lBoxDenumire.TabIndex = 20;
            this.lBoxDenumire.Text = "Denumire";
            this.lBoxDenumire.UseCustomForeColor = true;
            // 
            // lBoxProducator
            // 
            this.lBoxProducator.AutoSize = true;
            this.lBoxProducator.ForeColor = System.Drawing.Color.Black;
            this.lBoxProducator.Location = new System.Drawing.Point(772, 119);
            this.lBoxProducator.Name = "lBoxProducator";
            this.lBoxProducator.Size = new System.Drawing.Size(75, 19);
            this.lBoxProducator.TabIndex = 21;
            this.lBoxProducator.Text = "Producator";
            // 
            // lBoxCPU
            // 
            this.lBoxCPU.AutoSize = true;
            this.lBoxCPU.ForeColor = System.Drawing.Color.Black;
            this.lBoxCPU.Location = new System.Drawing.Point(808, 147);
            this.lBoxCPU.Name = "lBoxCPU";
            this.lBoxCPU.Size = new System.Drawing.Size(35, 19);
            this.lBoxCPU.TabIndex = 22;
            this.lBoxCPU.Text = "CPU";
            // 
            // lBoxProducator_GPU
            // 
            this.lBoxProducator_GPU.AutoSize = true;
            this.lBoxProducator_GPU.ForeColor = System.Drawing.Color.Black;
            this.lBoxProducator_GPU.Location = new System.Drawing.Point(741, 175);
            this.lBoxProducator_GPU.Name = "lBoxProducator_GPU";
            this.lBoxProducator_GPU.Size = new System.Drawing.Size(105, 19);
            this.lBoxProducator_GPU.TabIndex = 23;
            this.lBoxProducator_GPU.Text = "Producator GPU";
            // 
            // lBoxGPU
            // 
            this.lBoxGPU.AutoSize = true;
            this.lBoxGPU.ForeColor = System.Drawing.Color.Black;
            this.lBoxGPU.Location = new System.Drawing.Point(808, 203);
            this.lBoxGPU.Name = "lBoxGPU";
            this.lBoxGPU.Size = new System.Drawing.Size(35, 19);
            this.lBoxGPU.TabIndex = 24;
            this.lBoxGPU.Text = "GPU";
            // 
            // lBoxRAM
            // 
            this.lBoxRAM.AutoSize = true;
            this.lBoxRAM.ForeColor = System.Drawing.Color.Black;
            this.lBoxRAM.Location = new System.Drawing.Point(806, 231);
            this.lBoxRAM.Name = "lBoxRAM";
            this.lBoxRAM.Size = new System.Drawing.Size(38, 19);
            this.lBoxRAM.TabIndex = 25;
            this.lBoxRAM.Text = "RAM";
            this.lBoxRAM.UseCustomForeColor = true;
            // 
            // lBoxStocare
            // 
            this.lBoxStocare.AutoSize = true;
            this.lBoxStocare.ForeColor = System.Drawing.Color.Black;
            this.lBoxStocare.Location = new System.Drawing.Point(789, 259);
            this.lBoxStocare.Name = "lBoxStocare";
            this.lBoxStocare.Size = new System.Drawing.Size(53, 19);
            this.lBoxStocare.TabIndex = 26;
            this.lBoxStocare.Text = "Stocare";
            // 
            // lBoxCarcasa
            // 
            this.lBoxCarcasa.AutoSize = true;
            this.lBoxCarcasa.ForeColor = System.Drawing.Color.Black;
            this.lBoxCarcasa.Location = new System.Drawing.Point(789, 287);
            this.lBoxCarcasa.Name = "lBoxCarcasa";
            this.lBoxCarcasa.Size = new System.Drawing.Size(55, 19);
            this.lBoxCarcasa.TabIndex = 27;
            this.lBoxCarcasa.Text = "Carcasa";
            // 
            // lBoxFront_Panel
            // 
            this.lBoxFront_Panel.AutoSize = true;
            this.lBoxFront_Panel.ForeColor = System.Drawing.Color.Black;
            this.lBoxFront_Panel.Location = new System.Drawing.Point(768, 315);
            this.lBoxFront_Panel.Name = "lBoxFront_Panel";
            this.lBoxFront_Panel.Size = new System.Drawing.Size(75, 19);
            this.lBoxFront_Panel.TabIndex = 28;
            this.lBoxFront_Panel.Text = "Front Panel";
            // 
            // lBoxSursa
            // 
            this.lBoxSursa.AutoSize = true;
            this.lBoxSursa.ForeColor = System.Drawing.Color.Black;
            this.lBoxSursa.Location = new System.Drawing.Point(801, 343);
            this.lBoxSursa.Name = "lBoxSursa";
            this.lBoxSursa.Size = new System.Drawing.Size(40, 19);
            this.lBoxSursa.TabIndex = 29;
            this.lBoxSursa.Text = "Sursa";
            // 
            // lBoxNume
            // 
            this.lBoxNume.AutoSize = true;
            this.lBoxNume.ForeColor = System.Drawing.Color.Black;
            this.lBoxNume.Location = new System.Drawing.Point(984, 91);
            this.lBoxNume.Name = "lBoxNume";
            this.lBoxNume.Size = new System.Drawing.Size(45, 19);
            this.lBoxNume.TabIndex = 30;
            this.lBoxNume.Text = "Nume";
            // 
            // lBoxPrenume
            // 
            this.lBoxPrenume.AutoSize = true;
            this.lBoxPrenume.ForeColor = System.Drawing.Color.Black;
            this.lBoxPrenume.Location = new System.Drawing.Point(984, 119);
            this.lBoxPrenume.Name = "lBoxPrenume";
            this.lBoxPrenume.Size = new System.Drawing.Size(62, 19);
            this.lBoxPrenume.TabIndex = 31;
            this.lBoxPrenume.Text = "Prenume";
            // 
            // lBoxGen
            // 
            this.lBoxGen.AutoSize = true;
            this.lBoxGen.ForeColor = System.Drawing.Color.Black;
            this.lBoxGen.Location = new System.Drawing.Point(984, 147);
            this.lBoxGen.Name = "lBoxGen";
            this.lBoxGen.Size = new System.Drawing.Size(32, 19);
            this.lBoxGen.TabIndex = 32;
            this.lBoxGen.Text = "Gen";
            // 
            // lBoxEmail
            // 
            this.lBoxEmail.AutoSize = true;
            this.lBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.lBoxEmail.Location = new System.Drawing.Point(984, 175);
            this.lBoxEmail.Name = "lBoxEmail";
            this.lBoxEmail.Size = new System.Drawing.Size(41, 19);
            this.lBoxEmail.TabIndex = 33;
            this.lBoxEmail.Text = "Email";
            // 
            // lBoxAdresa
            // 
            this.lBoxAdresa.AutoSize = true;
            this.lBoxAdresa.ForeColor = System.Drawing.Color.Black;
            this.lBoxAdresa.Location = new System.Drawing.Point(984, 203);
            this.lBoxAdresa.Name = "lBoxAdresa";
            this.lBoxAdresa.Size = new System.Drawing.Size(50, 19);
            this.lBoxAdresa.TabIndex = 34;
            this.lBoxAdresa.Text = "Adresa";
            // 
            // lBoxTelefon
            // 
            this.lBoxTelefon.AutoSize = true;
            this.lBoxTelefon.ForeColor = System.Drawing.Color.Black;
            this.lBoxTelefon.Location = new System.Drawing.Point(984, 231);
            this.lBoxTelefon.Name = "lBoxTelefon";
            this.lBoxTelefon.Size = new System.Drawing.Size(50, 19);
            this.lBoxTelefon.TabIndex = 35;
            this.lBoxTelefon.Text = "Telefon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 632);
            this.Controls.Add(this.lBoxTelefon);
            this.Controls.Add(this.lBoxAdresa);
            this.Controls.Add(this.lBoxEmail);
            this.Controls.Add(this.lBoxGen);
            this.Controls.Add(this.lBoxPrenume);
            this.Controls.Add(this.lBoxNume);
            this.Controls.Add(this.lBoxSursa);
            this.Controls.Add(this.lBoxFront_Panel);
            this.Controls.Add(this.lBoxCarcasa);
            this.Controls.Add(this.lBoxStocare);
            this.Controls.Add(this.lBoxRAM);
            this.Controls.Add(this.lBoxGPU);
            this.Controls.Add(this.lBoxProducator_GPU);
            this.Controls.Add(this.lBoxCPU);
            this.Controls.Add(this.lBoxProducator);
            this.Controls.Add(this.lBoxDenumire);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.Sursa);
            this.Controls.Add(this.Front_Panel);
            this.Controls.Add(this.Carcasa);
            this.Controls.Add(this.Stocare);
            this.Controls.Add(this.RAM);
            this.Controls.Add(this.GPU);
            this.Controls.Add(this.Producator_GPU);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.Producator);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroLabel label1;
        private MetroLabel label2;
        private MetroTextBox Denumire;
        private MetroTextBox Producator;
        private MetroTextBox CPU;
        private MetroTextBox Producator_GPU;
        private MetroTextBox GPU;
        private MetroTextBox RAM;
        private MetroTextBox Stocare;
        private MetroTextBox Carcasa;
        private MetroTextBox Front_Panel;
        private MetroTextBox Sursa;
        private MetroTextBox Nume;
        private MetroTextBox Prenume;
        private MetroTextBox Gen;
        private MetroTextBox Email;
        private MetroTextBox Adresa;
        private MetroTextBox Telefon;
        private MetroButton button1;
        private MetroButton button2;
        private MetroLabel lBoxDenumire;
        private MetroLabel lBoxProducator;
        private MetroLabel lBoxCPU;
        private MetroLabel lBoxProducator_GPU;
        private MetroLabel lBoxGPU;
        private MetroLabel lBoxRAM;
        private MetroLabel lBoxStocare;
        private MetroLabel lBoxCarcasa;
        private MetroLabel lBoxFront_Panel;
        private MetroLabel lBoxSursa;
        private MetroLabel lBoxNume;
        private MetroLabel lBoxPrenume;
        private MetroLabel lBoxGen;
        private MetroLabel lBoxEmail;
        private MetroLabel lBoxAdresa;
        private MetroLabel lBoxTelefon;
    }
}

