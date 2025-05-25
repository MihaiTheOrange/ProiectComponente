using LibrarieModele;
using MetroFramework.Controls;
using MetroFramework.Forms;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace ComponenteProiect
{
    public partial class Form1: MetroForm
    {
        AdministrareCalculator_FisierText adminCalc;
        AdministrareUser_FIsierText adminUser;
       
        //AdministrareUser_FIsierText adminUser;


        //Calculatoare
        private MetroLabel lblDenumire;
        private MetroLabel lblProducator;
        private MetroLabel lblCPU;
        private MetroLabel lblProducatorGPU;
        private MetroLabel lblGPU;
        private MetroLabel lblCapacitateRAM;
        private MetroLabel lblCapacitateStocare;
        private MetroLabel lblCarcasa;
        private MetroLabel lblFrontPanel;
        private MetroLabel lblSursa;
        
        private MetroLabel[] lblsDenumire;
        private MetroLabel[] lblsProducator;
        private MetroLabel[] lblsCPU;
        private MetroLabel[] lblsProducatorGPU;
        private MetroLabel[] lblsGPU;
        private MetroLabel[] lblsCapacitateRAM;
        private MetroLabel[] lblsCapacitateStocare;
        private MetroLabel[] lblsCarcasa;
        private MetroLabel[] lblsFrontPanel;
        private MetroLabel[] lblsSursa;

        //Useri
        private MetroLabel lblNume;
        private MetroLabel lblPrenume;

        private MetroLabel[] lblsNume;
        private MetroLabel[] lblsPrenume;


        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 100;

        private const string locatieFisierCalculatoare = "C:\\Users\\Mihai\\source\\repos\\ProiectComponente\\ProiectComponente\\bin\\Debug\\Calculatoare.txt";
        private const string locatieFisierUseri = "C:\\Users\\Mihai\\source\\repos\\ProiectComponente\\ProiectComponente\\bin\\Debug\\Useri.txt";
        public Form1()
        {
            InitializeComponent();
            adminCalc = new AdministrareCalculator_FisierText(locatieFisierCalculatoare);
            int nrCalculatoare = 0;
            List<Calculator> calculatoare = adminCalc.GetCalculatoare(out nrCalculatoare);

            adminUser = new AdministrareUser_FIsierText(locatieFisierUseri);
            int nrUseri = 0;
            List<User> useri = adminUser.GetUseri(out nrUseri);


            //Setare proprietati
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Regular);
            this.ForeColor = Color.Gray;
            this.Text = "Calculatoare";


            //controale de tip MetroLabel
            lblDenumire = new MetroLabel();
            lblDenumire.Width = LATIME_CONTROL;
            lblDenumire.Text = "Denumire";
            lblDenumire.Left = 0*DIMENSIUNE_PAS_X;
            lblDenumire.ForeColor = Color.Black;
            this.Controls.Add(lblDenumire);

            lblProducator = new MetroLabel();
            lblProducator.Width = LATIME_CONTROL;
            lblProducator.Text = "Producator";
            lblProducator.Left = 1*DIMENSIUNE_PAS_X;
            lblProducator.ForeColor = Color.Black;
            this.Controls.Add((lblProducator) );

            //lblCPU
            lblCPU = new MetroLabel();
            lblCPU.Width = LATIME_CONTROL;
            lblCPU.Text = "CPU";
            lblCPU.Left = 2*DIMENSIUNE_PAS_X;
            lblCPU.ForeColor = Color.Black;
            this.Controls.Add((lblCPU));

            //lblProducatorGPU
            //lblProducatorGPU = new MetroLabel();
            //lblProducatorGPU.Width = LATIME_CONTROL;
            //lblProducatorGPU.Text = "Producator GPU";
            //lblProducatorGPU.Left = 4 * DIMENSIUNE_PAS_X;
            //lblProducatorGPU.ForeColor = Color.Black;
            //this.Controls.Add((lblProducatorGPU));

            //lblGPU
            lblGPU = new MetroLabel();
            lblGPU.Width = LATIME_CONTROL;
            lblGPU.Text = "GPU";
            lblGPU.Left = 3 * DIMENSIUNE_PAS_X;
            lblGPU.ForeColor = Color.Black;
            this.Controls.Add((lblGPU));

            //lblCapacitateRAM
            lblCapacitateRAM = new MetroLabel();
            lblCapacitateRAM.Width = LATIME_CONTROL;
            lblCapacitateRAM.Text = "Capacitate RAM";
            lblCapacitateRAM.Left = 4 * DIMENSIUNE_PAS_X;
            lblCapacitateRAM.ForeColor = Color.Black;
            this.Controls.Add((lblCapacitateRAM));

            //lblCapacitateStocare
            //lblCapacitateStocare = new MetroLabel();
            //lblCapacitateStocare.Width = LATIME_CONTROL;
            //lblCapacitateStocare.Text = "Capacitate Stocare";
            //lblCapacitateStocare.Left = 7 * DIMENSIUNE_PAS_X;
            //lblCapacitateStocare.ForeColor = Color.Black;
            //this.Controls.Add((lblCapacitateStocare));

            //lblCarcasa
            //lblCarcasa = new MetroLabel();
            //lblCarcasa.Width = LATIME_CONTROL;
            //lblCarcasa.Text = "Carcasa";
            //lblCarcasa.Left = 8 * DIMENSIUNE_PAS_X;
            //lblCarcasa.ForeColor = Color.Black;
            //this.Controls.Add((lblCarcasa));

            //lblFrontPanel
            //lblFrontPanel = new MetroLabel();
            //lblFrontPanel.Width = LATIME_CONTROL;
            //lblFrontPanel.Text = "Front Panel";
            //lblFrontPanel.Left = 9 * DIMENSIUNE_PAS_X;
            //lblFrontPanel.ForeColor = Color.Black;
            //this.Controls.Add((lblFrontPanel));

            //lblSursa
            //lblSursa = new MetroLabel();
            //lblSursa.Width = LATIME_CONTROL;
            //lblSursa.Text = "Sursa";
            //lblSursa.Left = 10 * DIMENSIUNE_PAS_X;
            //lblSursa.ForeColor = Color.Black;
            //this.Controls.Add((lblSursa));



            lblNume = new MetroLabel();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Nume";
            lblNume.Left = 6 * DIMENSIUNE_PAS_X;
            lblNume.ForeColor = Color.Black;
            this.Controls.Add(lblNume);

            lblPrenume = new MetroLabel();
            lblPrenume.Width = LATIME_CONTROL;
            lblPrenume.Text = "Prenume";
            lblPrenume.Left = 7 * DIMENSIUNE_PAS_X;
            lblPrenume.ForeColor = Color.Black;
            this.Controls.Add(lblPrenume);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfisareCalculatoare();
            AfisareUseri();
        }

        private void testMetroLabel(MetroLabel test)
        {
            List<Calculator> calculatoare = adminCalc.GetCalculatoare(out int nrCalculatoare);
            test.Width = LATIME_CONTROL;
            test.Text = calculatoare.Count.ToString();
            test.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(test);
        }

        private void AfisareUseri()
        {
            List<User> useri = adminUser.GetUseri(out int nrUseri);
            lblsNume = new MetroLabel[nrUseri];
            lblsPrenume = new MetroLabel[nrUseri];
            int i = 0;
            foreach (User user in useri)
            {
                lblsNume[i] = new MetroLabel();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = user.nume;
                lblsNume[i].Left = 6 * DIMENSIUNE_PAS_X;
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);
                lblsPrenume[i] = new MetroLabel();
                lblsPrenume[i].Width = LATIME_CONTROL;
                lblsPrenume[i].Text = user.prenume;
                lblsPrenume[i].Left = 7 * DIMENSIUNE_PAS_X;
                lblsPrenume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPrenume[i]);
                i++;
            }
        }

        private void AfisareCalculatoare()
        {
            List<Calculator> calculatoare = adminCalc.GetCalculatoare(out int nrCalculatoare);
            
            lblsDenumire = new MetroLabel[nrCalculatoare];
            lblsProducator = new MetroLabel[nrCalculatoare];
            lblsCPU = new MetroLabel[nrCalculatoare];
            //lblsProducatorGPU = new MetroLabel[nrCalculatoare];
            lblsGPU = new MetroLabel[nrCalculatoare];
            lblsCapacitateRAM = new MetroLabel[nrCalculatoare];
            //lblsCapacitateStocare = new MetroLabel[nrCalculatoare];
            //lblsCarcasa = new MetroLabel[nrCalculatoare];
            //lblsFrontPanel = new MetroLabel[nrCalculatoare];
            //lblsSursa = new MetroLabel[nrCalculatoare];



            int i = 0;
            foreach(Calculator calculator in calculatoare)
            {
                lblsDenumire[i] = new MetroLabel();
                lblsDenumire[i].Width = LATIME_CONTROL;
                lblsDenumire[i].Text = calculator.denumire;
                lblsDenumire[i].Left = 0*DIMENSIUNE_PAS_X;
                lblsDenumire[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsDenumire[i]);

                lblsProducator[i] = new MetroLabel();
                lblsProducator[i].Width = LATIME_CONTROL;
                lblsProducator[i].Text = calculator.producator;
                lblsProducator[i].Left = 1 * DIMENSIUNE_PAS_X;
                lblsProducator[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsProducator[i]);

                lblsCPU[i] = new MetroLabel();
                lblsCPU[i].Width = LATIME_CONTROL;
                lblsCPU[i].Text = calculator.CPU;
                lblsCPU[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsCPU[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCPU[i]);

                //lblsProducatorGPU[i] = new MetroLabel();
                //lblsProducatorGPU[i].Width = LATIME_CONTROL;
                //lblsProducatorGPU[i].Text = calculator.producatorGPU.ToString();
                //lblsProducatorGPU[i].Left = 4 * DIMENSIUNE_PAS_X;
                //lblsProducatorGPU[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                //this.Controls.Add(lblsProducatorGPU[i]);

                lblsGPU[i] = new MetroLabel();
                lblsGPU[i].Width = LATIME_CONTROL;
                lblsGPU[i].Text = calculator.GPU;
                lblsGPU[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsGPU[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsGPU[i]);

                lblsCapacitateRAM[i] = new MetroLabel();
                lblsCapacitateRAM[i].Width = LATIME_CONTROL;
                lblsCapacitateRAM[i].Text = calculator.capacitateRAM.ToString();
                lblsCapacitateRAM[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsCapacitateRAM[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCapacitateRAM[i]);

                //lblsCapacitateStocare[i] = new MetroLabel();
                //lblsCapacitateStocare[i].Width = LATIME_CONTROL;
                //lblsCapacitateStocare[i].Text = calculator.capacitateStocare.ToString();
                //lblsCapacitateStocare[i].Left = 7 * DIMENSIUNE_PAS_X;
                //lblsCapacitateStocare[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                //this.Controls.Add(lblsCapacitateStocare[i]);

                //lblsCarcasa[i] = new MetroLabel();
                //lblsCarcasa[i].Width = LATIME_CONTROL;
                //lblsCarcasa[i].Text = calculator.carcasa;
                //lblsCarcasa[i].Left = 8 * DIMENSIUNE_PAS_X;
                //lblsCarcasa[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                //this.Controls.Add(lblsCarcasa[i]);

                //lblsFrontPanel[i] = new MetroLabel();
                //lblsFrontPanel[i].Width = LATIME_CONTROL;
                //lblsFrontPanel[i].Text = calculator.frontPanel.ToString();
                //lblsFrontPanel[i].Left = 9 * DIMENSIUNE_PAS_X;
                //lblsFrontPanel[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                //this.Controls.Add(lblsFrontPanel[i]);

                //lblsSursa[i] = new MetroLabel();
                //lblsSursa[i].Width = LATIME_CONTROL;
                //lblsSursa[i].Text = calculator.sursa.ToString();
                //lblsSursa[i].Left = 10 * DIMENSIUNE_PAS_X;
                //lblsSursa[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                //this.Controls.Add(lblsSursa[i]);
                
                i++;
            }
    }
        private bool validareMetroTextBoxString(MetroTextBox MetroTextBox)
        {
            if (MetroTextBox.Text == "")
            {
                return false;
            }
            if (MetroTextBox.Text.Length < 3)
            {
                return false;
            }
            if (MetroTextBox.Text.Length > 20)
            {
                return false;
            }
            return true;
        }
        private bool validareMetroTextBoxInt(MetroTextBox MetroTextBox)
        {
            if (MetroTextBox.Text == "")
            {
                return false;
            }
            if (!int.TryParse(MetroTextBox.Text, out int result))
            {
                return false;
            }
            if (result < 0)
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Calculator calculatorNou;
                string denumire = Denumire.Text;
                string producator = Producator.Text;
                string CPU = this.CPU.Text;
                string producatorGPU = Producator_GPU.Text;
                string GPU = this.GPU.Text;
                int capacitateRAM = int.Parse(RAM.Text);
                int capacitateStocare = int.Parse(Stocare.Text);
                string carcasa = Carcasa.Text;
                string frontPanel = Front_Panel.Text;
                int sursa = int.Parse(Sursa.Text);
                calculatorNou = new Calculator(denumire, producator, CPU, (int)Enum.Parse(typeof(ProducatorGPU), producatorGPU), GPU, capacitateRAM, capacitateStocare, carcasa, frontPanel, sursa);

                adminCalc.GetCalculatoare(out int nrCalculatoare);

                adminCalc.AddCalculator(calculatorNou, ref nrCalculatoare);
                AfisareCalculatoare();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare neasteptata");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                User userNou;
                string nume = Nume.Text;
                string prenume = Prenume.Text;
                int gen = int.Parse(Gen.Text);
                string email = Email.Text;
                string adresa = Adresa.Text;
                string nrTelefon = Telefon.Text;
                userNou = new User(nume, prenume, gen, email, adresa, nrTelefon);

                adminUser.GetUseri(out int nrUseri);
                adminUser.AddUser(userNou, ref nrUseri);
                AfisareUseri();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare neasteptata");
            }
        }




        //Calculatoare
        private void Denumire_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(Denumire))
            {
                lBoxDenumire.ForeColor = Color.Red;
            }
            else
            {
                lBoxDenumire.ForeColor = Color.Black;
            }
        }

        private void Producator_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(Producator))
            {
                lBoxProducator.ForeColor = Color.Red;
            }
            else
            {
                lBoxProducator.ForeColor = Color.Black;
            }
        }

        private void CPU_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(CPU))
            {
                lBoxCPU.ForeColor = Color.Red;
            }
            else
            {
                lBoxCPU.ForeColor = Color.Black;
            }
        }

        private void Producator_GPU_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(Producator_GPU))
            {
                lBoxProducator_GPU.ForeColor = Color.Red;
            }
            else
            {
                lBoxProducator_GPU.ForeColor = Color.Black;
            }
        }

        private void GPU_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(GPU))
            {
                lBoxGPU.ForeColor = Color.Red;
            }
            else
            {
                lBoxGPU.ForeColor = Color.Black;
            }
        }

        private void RAM_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxInt(RAM))
            {
                lBoxRAM.ForeColor = Color.Red;
            }
            else
            {
                lBoxRAM.ForeColor = Color.Black;
            }
        }

        private void Stocare_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxInt(Stocare))
            {
                lBoxStocare.ForeColor = Color.Red;
            }
            else
            {
                lBoxStocare.ForeColor = Color.Black;
            }
        }

        private void Carcasa_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(Carcasa))
            {
                lBoxCarcasa.ForeColor = Color.Red;
            }
            else
            {
                lBoxCarcasa.ForeColor = Color.Black;
            }
        }

        private void Front_Panel_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(Front_Panel))
            {
                lBoxFront_Panel.ForeColor = Color.Red;
            }
            else
            {
                lBoxFront_Panel.ForeColor = Color.Black;
            }
        }

        private void Sursa_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxInt(Sursa))
            {
                lBoxSursa.ForeColor = Color.Red;
            }
            else
            {
                lBoxSursa.ForeColor = Color.Black;
            }
        }



        //Useri
        private void Nume_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(Nume))
            {
                lBoxNume.ForeColor = Color.Red;
            }
            else
            {
                lBoxNume.ForeColor = Color.Black;
            }
        }

        private void Prenume_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(Prenume))
            {
                lBoxPrenume.ForeColor = Color.Red;
            }
            else
            {
                lBoxPrenume.ForeColor = Color.Black;
            }
        }

        private void Gen_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxInt(Gen))
            {
                lBoxGen.ForeColor = Color.Red;
            }
            else
            {
                lBoxGen.ForeColor = Color.Black;
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(Email))
            {
                lBoxEmail.ForeColor = Color.Red;
            }
            else
            {
                lBoxEmail.ForeColor = Color.Black;
            }
        }

        private void Adresa_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(Adresa))
            {
                lBoxAdresa.ForeColor = Color.Red;
            }
            else
            {
                lBoxAdresa.ForeColor = Color.Black;
            }
        }

        private void Telefon_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(Telefon))
            {
                lBoxTelefon.ForeColor = Color.Red;
            }
            else
            {
                lBoxTelefon.ForeColor = Color.Black;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Nume_Click(object sender, EventArgs e)
        {

        }

        private void Producator_Click(object sender, EventArgs e)
        {

        }
    }
}
