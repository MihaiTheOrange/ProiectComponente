namespace ComponenteProiect
{
    partial class AddCalculatorForm
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
            this.lBoxSursa = new MetroFramework.Controls.MetroLabel();
            this.lBoxCarcasa = new MetroFramework.Controls.MetroLabel();
            this.lBoxStocare = new MetroFramework.Controls.MetroLabel();
            this.lBoxRAM = new MetroFramework.Controls.MetroLabel();
            this.lBoxGPU = new MetroFramework.Controls.MetroLabel();
            this.lBoxCPU = new MetroFramework.Controls.MetroLabel();
            this.lBoxProducator = new MetroFramework.Controls.MetroLabel();
            this.lBoxDenumire = new MetroFramework.Controls.MetroLabel();
            this.AddCalc = new MetroFramework.Controls.MetroButton();
            this.Sursa = new MetroFramework.Controls.MetroTextBox();
            this.Carcasa = new MetroFramework.Controls.MetroTextBox();
            this.Stocare = new MetroFramework.Controls.MetroTextBox();
            this.RAM = new MetroFramework.Controls.MetroTextBox();
            this.GPU = new MetroFramework.Controls.MetroTextBox();
            this.CPU = new MetroFramework.Controls.MetroTextBox();
            this.Producator = new MetroFramework.Controls.MetroTextBox();
            this.Denumire = new MetroFramework.Controls.MetroTextBox();
            this.nvidiaRad = new MetroFramework.Controls.MetroRadioButton();
            this.amdRad = new MetroFramework.Controls.MetroRadioButton();
            this.qualcommRad = new MetroFramework.Controls.MetroRadioButton();
            this.otherRad = new MetroFramework.Controls.MetroRadioButton();
            this.intelRad = new MetroFramework.Controls.MetroRadioButton();
            this.ProducatorGpuBox = new System.Windows.Forms.GroupBox();
            this.FrontPanelBox = new System.Windows.Forms.GroupBox();
            this.jack6_35chk = new MetroFramework.Controls.MetroCheckBox();
            this.jack3_5chk = new MetroFramework.Controls.MetroCheckBox();
            this.jack2_5chk = new MetroFramework.Controls.MetroCheckBox();
            this.thunderboltchk = new MetroFramework.Controls.MetroCheckBox();
            this.usbcchk = new MetroFramework.Controls.MetroCheckBox();
            this.usb3_1chk = new MetroFramework.Controls.MetroCheckBox();
            this.usb3chk = new MetroFramework.Controls.MetroCheckBox();
            this.usb2chk = new MetroFramework.Controls.MetroCheckBox();
            this.CancelButton = new MetroFramework.Controls.MetroButton();
            this.ProducatorGpuBox.SuspendLayout();
            this.FrontPanelBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxSursa
            // 
            this.lBoxSursa.AutoSize = true;
            this.lBoxSursa.ForeColor = System.Drawing.Color.Black;
            this.lBoxSursa.Location = new System.Drawing.Point(297, 153);
            this.lBoxSursa.Name = "lBoxSursa";
            this.lBoxSursa.Size = new System.Drawing.Size(40, 19);
            this.lBoxSursa.TabIndex = 50;
            this.lBoxSursa.Text = "Sursa";
            // 
            // lBoxCarcasa
            // 
            this.lBoxCarcasa.AutoSize = true;
            this.lBoxCarcasa.ForeColor = System.Drawing.Color.Black;
            this.lBoxCarcasa.Location = new System.Drawing.Point(282, 119);
            this.lBoxCarcasa.Name = "lBoxCarcasa";
            this.lBoxCarcasa.Size = new System.Drawing.Size(55, 19);
            this.lBoxCarcasa.TabIndex = 48;
            this.lBoxCarcasa.Text = "Carcasa";
            // 
            // lBoxStocare
            // 
            this.lBoxStocare.AutoSize = true;
            this.lBoxStocare.ForeColor = System.Drawing.Color.Black;
            this.lBoxStocare.Location = new System.Drawing.Point(284, 91);
            this.lBoxStocare.Name = "lBoxStocare";
            this.lBoxStocare.Size = new System.Drawing.Size(53, 19);
            this.lBoxStocare.TabIndex = 47;
            this.lBoxStocare.Text = "Stocare";
            // 
            // lBoxRAM
            // 
            this.lBoxRAM.AutoSize = true;
            this.lBoxRAM.ForeColor = System.Drawing.Color.Black;
            this.lBoxRAM.Location = new System.Drawing.Point(299, 63);
            this.lBoxRAM.Name = "lBoxRAM";
            this.lBoxRAM.Size = new System.Drawing.Size(38, 19);
            this.lBoxRAM.TabIndex = 46;
            this.lBoxRAM.Text = "RAM";
            this.lBoxRAM.UseCustomForeColor = true;
            // 
            // lBoxGPU
            // 
            this.lBoxGPU.AutoSize = true;
            this.lBoxGPU.ForeColor = System.Drawing.Color.Black;
            this.lBoxGPU.Location = new System.Drawing.Point(83, 149);
            this.lBoxGPU.Name = "lBoxGPU";
            this.lBoxGPU.Size = new System.Drawing.Size(35, 19);
            this.lBoxGPU.TabIndex = 45;
            this.lBoxGPU.Text = "GPU";
            // 
            // lBoxCPU
            // 
            this.lBoxCPU.AutoSize = true;
            this.lBoxCPU.ForeColor = System.Drawing.Color.Black;
            this.lBoxCPU.Location = new System.Drawing.Point(83, 119);
            this.lBoxCPU.Name = "lBoxCPU";
            this.lBoxCPU.Size = new System.Drawing.Size(35, 19);
            this.lBoxCPU.TabIndex = 43;
            this.lBoxCPU.Text = "CPU";
            // 
            // lBoxProducator
            // 
            this.lBoxProducator.AutoSize = true;
            this.lBoxProducator.ForeColor = System.Drawing.Color.Black;
            this.lBoxProducator.Location = new System.Drawing.Point(46, 94);
            this.lBoxProducator.Name = "lBoxProducator";
            this.lBoxProducator.Size = new System.Drawing.Size(75, 19);
            this.lBoxProducator.TabIndex = 42;
            this.lBoxProducator.Text = "Producator";
            // 
            // lBoxDenumire
            // 
            this.lBoxDenumire.AutoSize = true;
            this.lBoxDenumire.ForeColor = System.Drawing.Color.Black;
            this.lBoxDenumire.Location = new System.Drawing.Point(55, 63);
            this.lBoxDenumire.Name = "lBoxDenumire";
            this.lBoxDenumire.Size = new System.Drawing.Size(66, 19);
            this.lBoxDenumire.TabIndex = 41;
            this.lBoxDenumire.Text = "Denumire";
            this.lBoxDenumire.UseCustomForeColor = true;
            // 
            // AddCalc
            // 
            this.AddCalc.Location = new System.Drawing.Point(282, 378);
            this.AddCalc.Name = "AddCalc";
            this.AddCalc.Size = new System.Drawing.Size(74, 24);
            this.AddCalc.TabIndex = 40;
            this.AddCalc.Text = "Add";
            this.AddCalc.UseSelectable = true;
            this.AddCalc.Click += new System.EventHandler(this.AddCalc_Click);
            // 
            // Sursa
            // 
            // 
            // 
            // 
            this.Sursa.CustomButton.Image = null;
            this.Sursa.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.Sursa.CustomButton.Name = "";
            this.Sursa.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.Sursa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Sursa.CustomButton.TabIndex = 1;
            this.Sursa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Sursa.CustomButton.UseSelectable = true;
            this.Sursa.CustomButton.Visible = false;
            this.Sursa.Lines = new string[0];
            this.Sursa.Location = new System.Drawing.Point(348, 153);
            this.Sursa.MaxLength = 32767;
            this.Sursa.Name = "Sursa";
            this.Sursa.PasswordChar = '\0';
            this.Sursa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Sursa.SelectedText = "";
            this.Sursa.SelectionLength = 0;
            this.Sursa.SelectionStart = 0;
            this.Sursa.ShortcutsEnabled = true;
            this.Sursa.Size = new System.Drawing.Size(100, 19);
            this.Sursa.TabIndex = 39;
            this.Sursa.UseSelectable = true;
            this.Sursa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Sursa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Carcasa
            // 
            // 
            // 
            // 
            this.Carcasa.CustomButton.Image = null;
            this.Carcasa.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.Carcasa.CustomButton.Name = "";
            this.Carcasa.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.Carcasa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Carcasa.CustomButton.TabIndex = 1;
            this.Carcasa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Carcasa.CustomButton.UseSelectable = true;
            this.Carcasa.CustomButton.Visible = false;
            this.Carcasa.Lines = new string[0];
            this.Carcasa.Location = new System.Drawing.Point(348, 119);
            this.Carcasa.MaxLength = 32767;
            this.Carcasa.Name = "Carcasa";
            this.Carcasa.PasswordChar = '\0';
            this.Carcasa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Carcasa.SelectedText = "";
            this.Carcasa.SelectionLength = 0;
            this.Carcasa.SelectionStart = 0;
            this.Carcasa.ShortcutsEnabled = true;
            this.Carcasa.Size = new System.Drawing.Size(100, 19);
            this.Carcasa.TabIndex = 37;
            this.Carcasa.UseSelectable = true;
            this.Carcasa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Carcasa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Stocare
            // 
            // 
            // 
            // 
            this.Stocare.CustomButton.Image = null;
            this.Stocare.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.Stocare.CustomButton.Name = "";
            this.Stocare.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.Stocare.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Stocare.CustomButton.TabIndex = 1;
            this.Stocare.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Stocare.CustomButton.UseSelectable = true;
            this.Stocare.CustomButton.Visible = false;
            this.Stocare.Lines = new string[0];
            this.Stocare.Location = new System.Drawing.Point(348, 91);
            this.Stocare.MaxLength = 32767;
            this.Stocare.Name = "Stocare";
            this.Stocare.PasswordChar = '\0';
            this.Stocare.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Stocare.SelectedText = "";
            this.Stocare.SelectionLength = 0;
            this.Stocare.SelectionStart = 0;
            this.Stocare.ShortcutsEnabled = true;
            this.Stocare.Size = new System.Drawing.Size(100, 19);
            this.Stocare.TabIndex = 36;
            this.Stocare.UseSelectable = true;
            this.Stocare.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Stocare.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RAM
            // 
            // 
            // 
            // 
            this.RAM.CustomButton.Image = null;
            this.RAM.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.RAM.CustomButton.Name = "";
            this.RAM.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.RAM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RAM.CustomButton.TabIndex = 1;
            this.RAM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RAM.CustomButton.UseSelectable = true;
            this.RAM.CustomButton.Visible = false;
            this.RAM.Lines = new string[0];
            this.RAM.Location = new System.Drawing.Point(348, 63);
            this.RAM.MaxLength = 32767;
            this.RAM.Name = "RAM";
            this.RAM.PasswordChar = '\0';
            this.RAM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RAM.SelectedText = "";
            this.RAM.SelectionLength = 0;
            this.RAM.SelectionStart = 0;
            this.RAM.ShortcutsEnabled = true;
            this.RAM.Size = new System.Drawing.Size(100, 19);
            this.RAM.TabIndex = 35;
            this.RAM.UseSelectable = true;
            this.RAM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RAM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GPU
            // 
            // 
            // 
            // 
            this.GPU.CustomButton.Image = null;
            this.GPU.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.GPU.CustomButton.Name = "";
            this.GPU.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.GPU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.GPU.CustomButton.TabIndex = 1;
            this.GPU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GPU.CustomButton.UseSelectable = true;
            this.GPU.CustomButton.Visible = false;
            this.GPU.Lines = new string[0];
            this.GPU.Location = new System.Drawing.Point(129, 149);
            this.GPU.MaxLength = 32767;
            this.GPU.Name = "GPU";
            this.GPU.PasswordChar = '\0';
            this.GPU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GPU.SelectedText = "";
            this.GPU.SelectionLength = 0;
            this.GPU.SelectionStart = 0;
            this.GPU.ShortcutsEnabled = true;
            this.GPU.Size = new System.Drawing.Size(100, 19);
            this.GPU.TabIndex = 34;
            this.GPU.UseSelectable = true;
            this.GPU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GPU.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CPU
            // 
            // 
            // 
            // 
            this.CPU.CustomButton.Image = null;
            this.CPU.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.CPU.CustomButton.Name = "";
            this.CPU.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.CPU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CPU.CustomButton.TabIndex = 1;
            this.CPU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CPU.CustomButton.UseSelectable = true;
            this.CPU.CustomButton.Visible = false;
            this.CPU.Lines = new string[0];
            this.CPU.Location = new System.Drawing.Point(129, 119);
            this.CPU.MaxLength = 32767;
            this.CPU.Name = "CPU";
            this.CPU.PasswordChar = '\0';
            this.CPU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CPU.SelectedText = "";
            this.CPU.SelectionLength = 0;
            this.CPU.SelectionStart = 0;
            this.CPU.ShortcutsEnabled = true;
            this.CPU.Size = new System.Drawing.Size(100, 19);
            this.CPU.TabIndex = 32;
            this.CPU.UseSelectable = true;
            this.CPU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CPU.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Producator
            // 
            // 
            // 
            // 
            this.Producator.CustomButton.Image = null;
            this.Producator.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.Producator.CustomButton.Name = "";
            this.Producator.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.Producator.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Producator.CustomButton.TabIndex = 1;
            this.Producator.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Producator.CustomButton.UseSelectable = true;
            this.Producator.CustomButton.Visible = false;
            this.Producator.Lines = new string[0];
            this.Producator.Location = new System.Drawing.Point(129, 94);
            this.Producator.MaxLength = 32767;
            this.Producator.Name = "Producator";
            this.Producator.PasswordChar = '\0';
            this.Producator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Producator.SelectedText = "";
            this.Producator.SelectionLength = 0;
            this.Producator.SelectionStart = 0;
            this.Producator.ShortcutsEnabled = true;
            this.Producator.Size = new System.Drawing.Size(100, 19);
            this.Producator.TabIndex = 31;
            this.Producator.UseSelectable = true;
            this.Producator.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Producator.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Denumire
            // 
            // 
            // 
            // 
            this.Denumire.CustomButton.Image = null;
            this.Denumire.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.Denumire.CustomButton.Name = "";
            this.Denumire.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.Denumire.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Denumire.CustomButton.TabIndex = 1;
            this.Denumire.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Denumire.CustomButton.UseSelectable = true;
            this.Denumire.CustomButton.Visible = false;
            this.Denumire.Lines = new string[0];
            this.Denumire.Location = new System.Drawing.Point(129, 63);
            this.Denumire.MaxLength = 32767;
            this.Denumire.Name = "Denumire";
            this.Denumire.PasswordChar = '\0';
            this.Denumire.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Denumire.SelectedText = "";
            this.Denumire.SelectionLength = 0;
            this.Denumire.SelectionStart = 0;
            this.Denumire.ShortcutsEnabled = true;
            this.Denumire.Size = new System.Drawing.Size(100, 19);
            this.Denumire.TabIndex = 30;
            this.Denumire.UseSelectable = true;
            this.Denumire.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Denumire.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nvidiaRad
            // 
            this.nvidiaRad.AutoSize = true;
            this.nvidiaRad.Location = new System.Drawing.Point(20, 19);
            this.nvidiaRad.Name = "nvidiaRad";
            this.nvidiaRad.Size = new System.Drawing.Size(57, 15);
            this.nvidiaRad.TabIndex = 51;
            this.nvidiaRad.Text = "Nvidia";
            this.nvidiaRad.UseSelectable = true;
            // 
            // amdRad
            // 
            this.amdRad.AutoSize = true;
            this.amdRad.Location = new System.Drawing.Point(119, 19);
            this.amdRad.Name = "amdRad";
            this.amdRad.Size = new System.Drawing.Size(50, 15);
            this.amdRad.TabIndex = 52;
            this.amdRad.Text = "AMD";
            this.amdRad.UseSelectable = true;
            // 
            // qualcommRad
            // 
            this.qualcommRad.AutoSize = true;
            this.qualcommRad.Location = new System.Drawing.Point(295, 19);
            this.qualcommRad.Name = "qualcommRad";
            this.qualcommRad.Size = new System.Drawing.Size(83, 15);
            this.qualcommRad.TabIndex = 53;
            this.qualcommRad.Text = "Qualcomm";
            this.qualcommRad.UseSelectable = true;
            // 
            // otherRad
            // 
            this.otherRad.AutoSize = true;
            this.otherRad.Location = new System.Drawing.Point(20, 50);
            this.otherRad.Name = "otherRad";
            this.otherRad.Size = new System.Drawing.Size(53, 15);
            this.otherRad.TabIndex = 54;
            this.otherRad.Text = "Other";
            this.otherRad.UseSelectable = true;
            // 
            // intelRad
            // 
            this.intelRad.AutoSize = true;
            this.intelRad.Location = new System.Drawing.Point(212, 19);
            this.intelRad.Name = "intelRad";
            this.intelRad.Size = new System.Drawing.Size(46, 15);
            this.intelRad.TabIndex = 55;
            this.intelRad.Text = "Intel";
            this.intelRad.UseSelectable = true;
            // 
            // ProducatorGpuBox
            // 
            this.ProducatorGpuBox.Controls.Add(this.intelRad);
            this.ProducatorGpuBox.Controls.Add(this.otherRad);
            this.ProducatorGpuBox.Controls.Add(this.qualcommRad);
            this.ProducatorGpuBox.Controls.Add(this.amdRad);
            this.ProducatorGpuBox.Controls.Add(this.nvidiaRad);
            this.ProducatorGpuBox.Location = new System.Drawing.Point(10, 190);
            this.ProducatorGpuBox.Name = "ProducatorGpuBox";
            this.ProducatorGpuBox.Size = new System.Drawing.Size(438, 79);
            this.ProducatorGpuBox.TabIndex = 56;
            this.ProducatorGpuBox.TabStop = false;
            this.ProducatorGpuBox.Text = "Producator GPU";
            // 
            // FrontPanelBox
            // 
            this.FrontPanelBox.Controls.Add(this.jack6_35chk);
            this.FrontPanelBox.Controls.Add(this.jack3_5chk);
            this.FrontPanelBox.Controls.Add(this.jack2_5chk);
            this.FrontPanelBox.Controls.Add(this.thunderboltchk);
            this.FrontPanelBox.Controls.Add(this.usbcchk);
            this.FrontPanelBox.Controls.Add(this.usb3_1chk);
            this.FrontPanelBox.Controls.Add(this.usb3chk);
            this.FrontPanelBox.Controls.Add(this.usb2chk);
            this.FrontPanelBox.Location = new System.Drawing.Point(10, 275);
            this.FrontPanelBox.Name = "FrontPanelBox";
            this.FrontPanelBox.Size = new System.Drawing.Size(438, 78);
            this.FrontPanelBox.TabIndex = 57;
            this.FrontPanelBox.TabStop = false;
            this.FrontPanelBox.Text = "Front Panel";
            // 
            // jack6_35chk
            // 
            this.jack6_35chk.AutoSize = true;
            this.jack6_35chk.Location = new System.Drawing.Point(338, 40);
            this.jack6_35chk.Name = "jack6_35chk";
            this.jack6_35chk.Size = new System.Drawing.Size(69, 15);
            this.jack6_35chk.TabIndex = 7;
            this.jack6_35chk.Text = "Jack 6.35";
            this.jack6_35chk.UseSelectable = true;
            // 
            // jack3_5chk
            // 
            this.jack3_5chk.AutoSize = true;
            this.jack3_5chk.Location = new System.Drawing.Point(236, 40);
            this.jack3_5chk.Name = "jack3_5chk";
            this.jack3_5chk.Size = new System.Drawing.Size(63, 15);
            this.jack3_5chk.TabIndex = 6;
            this.jack3_5chk.Text = "Jack 3.5";
            this.jack3_5chk.UseSelectable = true;
            // 
            // jack2_5chk
            // 
            this.jack2_5chk.AutoSize = true;
            this.jack2_5chk.Location = new System.Drawing.Point(137, 40);
            this.jack2_5chk.Name = "jack2_5chk";
            this.jack2_5chk.Size = new System.Drawing.Size(63, 15);
            this.jack2_5chk.TabIndex = 5;
            this.jack2_5chk.Text = "Jack 2.5";
            this.jack2_5chk.UseSelectable = true;
            // 
            // thunderboltchk
            // 
            this.thunderboltchk.AutoSize = true;
            this.thunderboltchk.Location = new System.Drawing.Point(6, 40);
            this.thunderboltchk.Name = "thunderboltchk";
            this.thunderboltchk.Size = new System.Drawing.Size(88, 15);
            this.thunderboltchk.TabIndex = 4;
            this.thunderboltchk.Text = "Thunderbolt";
            this.thunderboltchk.UseSelectable = true;
            // 
            // usbcchk
            // 
            this.usbcchk.AutoSize = true;
            this.usbcchk.Location = new System.Drawing.Point(338, 19);
            this.usbcchk.Name = "usbcchk";
            this.usbcchk.Size = new System.Drawing.Size(55, 15);
            this.usbcchk.TabIndex = 3;
            this.usbcchk.Text = "USB C";
            this.usbcchk.UseSelectable = true;
            // 
            // usb3_1chk
            // 
            this.usb3_1chk.AutoSize = true;
            this.usb3_1chk.Location = new System.Drawing.Point(237, 19);
            this.usb3_1chk.Name = "usb3_1chk";
            this.usb3_1chk.Size = new System.Drawing.Size(62, 15);
            this.usb3_1chk.TabIndex = 2;
            this.usb3_1chk.Text = "USB 3.1";
            this.usb3_1chk.UseSelectable = true;
            // 
            // usb3chk
            // 
            this.usb3chk.AutoSize = true;
            this.usb3chk.Location = new System.Drawing.Point(137, 19);
            this.usb3chk.Name = "usb3chk";
            this.usb3chk.Size = new System.Drawing.Size(53, 15);
            this.usb3chk.TabIndex = 1;
            this.usb3chk.Text = "USB 3";
            this.usb3chk.UseSelectable = true;
            // 
            // usb2chk
            // 
            this.usb2chk.AutoSize = true;
            this.usb2chk.Location = new System.Drawing.Point(6, 19);
            this.usb2chk.Name = "usb2chk";
            this.usb2chk.Size = new System.Drawing.Size(53, 15);
            this.usb2chk.TabIndex = 0;
            this.usb2chk.Text = "USB 2";
            this.usb2chk.UseSelectable = true;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton.Location = new System.Drawing.Point(374, 378);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(74, 24);
            this.CancelButton.TabIndex = 58;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseCustomBackColor = true;
            this.CancelButton.UseSelectable = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 417);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FrontPanelBox);
            this.Controls.Add(this.ProducatorGpuBox);
            this.Controls.Add(this.lBoxSursa);
            this.Controls.Add(this.lBoxCarcasa);
            this.Controls.Add(this.lBoxStocare);
            this.Controls.Add(this.lBoxRAM);
            this.Controls.Add(this.lBoxGPU);
            this.Controls.Add(this.lBoxCPU);
            this.Controls.Add(this.lBoxProducator);
            this.Controls.Add(this.lBoxDenumire);
            this.Controls.Add(this.AddCalc);
            this.Controls.Add(this.Sursa);
            this.Controls.Add(this.Carcasa);
            this.Controls.Add(this.Stocare);
            this.Controls.Add(this.RAM);
            this.Controls.Add(this.GPU);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.Producator);
            this.Controls.Add(this.Denumire);
            this.Name = "AddCalculatorForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "AddCalculatorForm";
            this.Load += new System.EventHandler(this.AddCalculatorForm_Load);
            this.ProducatorGpuBox.ResumeLayout(false);
            this.ProducatorGpuBox.PerformLayout();
            this.FrontPanelBox.ResumeLayout(false);
            this.FrontPanelBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lBoxSursa;
        private MetroFramework.Controls.MetroLabel lBoxCarcasa;
        private MetroFramework.Controls.MetroLabel lBoxStocare;
        private MetroFramework.Controls.MetroLabel lBoxRAM;
        private MetroFramework.Controls.MetroLabel lBoxGPU;
        private MetroFramework.Controls.MetroLabel lBoxCPU;
        private MetroFramework.Controls.MetroLabel lBoxProducator;
        private MetroFramework.Controls.MetroLabel lBoxDenumire;
        private MetroFramework.Controls.MetroButton AddCalc;
        private MetroFramework.Controls.MetroTextBox Sursa;
        private MetroFramework.Controls.MetroTextBox Carcasa;
        private MetroFramework.Controls.MetroTextBox Stocare;
        private MetroFramework.Controls.MetroTextBox RAM;
        private MetroFramework.Controls.MetroTextBox GPU;
        private MetroFramework.Controls.MetroTextBox CPU;
        private MetroFramework.Controls.MetroTextBox Producator;
        private MetroFramework.Controls.MetroTextBox Denumire;
        private MetroFramework.Controls.MetroRadioButton nvidiaRad;
        private MetroFramework.Controls.MetroRadioButton amdRad;
        private MetroFramework.Controls.MetroRadioButton qualcommRad;
        private MetroFramework.Controls.MetroRadioButton otherRad;
        private MetroFramework.Controls.MetroRadioButton intelRad;
        private System.Windows.Forms.GroupBox ProducatorGpuBox;
        private System.Windows.Forms.GroupBox FrontPanelBox;
        private MetroFramework.Controls.MetroCheckBox jack6_35chk;
        private MetroFramework.Controls.MetroCheckBox jack3_5chk;
        private MetroFramework.Controls.MetroCheckBox jack2_5chk;
        private MetroFramework.Controls.MetroCheckBox thunderboltchk;
        private MetroFramework.Controls.MetroCheckBox usbcchk;
        private MetroFramework.Controls.MetroCheckBox usb3_1chk;
        private MetroFramework.Controls.MetroCheckBox usb3chk;
        private MetroFramework.Controls.MetroCheckBox usb2chk;
        private MetroFramework.Controls.MetroButton CancelButton;
    }
}