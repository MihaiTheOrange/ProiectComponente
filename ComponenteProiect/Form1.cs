using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelStocareDate;



namespace ComponenteProiect
{
    public partial class Form1: Form
    {
        AdministrareCalculator_FisierText adminCalc;

       
        //AdministrareUser_FIsierText adminUser;

        private Label lblDenumire;
        private Label lblProducator;
        private Label lblCPU;
        private Label lblProducatorGPU;
        private Label lblGPU;
        private Label lblCapacitateRAM;
        private Label lblCapacitateStocare;
        private Label lblCarcasa;
        private Label lblFrontPanel;
        private Label lblSursa;
        
        private Label[] lblsDenumire;
        private Label[] lblsProducator;
        private Label[] lblsCPU;
        private Label[] lblsProducatorGPU;
        private Label[] lblsGPU;
        private Label[] lblsCapacitateRAM;
        private Label[] lblsCapacitateStocare;
        private Label[] lblsCarcasa;
        private Label[] lblsFrontPanel;
        private Label[] lblsSursa;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;

        private const string locatieFisierCalculatoare = "C:\\Users\\Mihai\\source\\repos\\ProiectComponente\\ProiectComponente\\bin\\Debug\\Calculatoare.txt";
        public Form1()
        {
            InitializeComponent();
            adminCalc = new AdministrareCalculator_FisierText(locatieFisierCalculatoare);
            int nrCalculatoare = 0;
            Calculator[] calculatoare = adminCalc.GetCalculatoare(out nrCalculatoare);


            //Setare proprietati
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Regular);
            this.ForeColor = Color.Gray;
            this.Text = "Calculatoare";


            //controale de tip label
            lblDenumire = new Label();
            lblDenumire.Width = LATIME_CONTROL;
            lblDenumire.Text = "Denumire";
            lblDenumire.Left = DIMENSIUNE_PAS_X;
            lblDenumire.ForeColor = Color.Black;
            this.Controls.Add(lblDenumire);

            lblProducator = new Label();
            lblProducator.Width = LATIME_CONTROL;
            lblProducator.Text = "Producator";
            lblProducator.Left = 2*DIMENSIUNE_PAS_X;
            lblProducator.ForeColor = Color.Black;
            this.Controls.Add((lblProducator) );

            //lblCPU
            lblCPU = new Label();
            lblCPU.Width = LATIME_CONTROL;
            lblCPU.Text = "CPU";
            lblCPU.Left = 3*DIMENSIUNE_PAS_X;
            lblCPU.ForeColor = Color.Black;
            this.Controls.Add((lblCPU));

            //lblProducatorGPU
            lblProducatorGPU = new Label();
            lblProducatorGPU.Width = LATIME_CONTROL;
            lblProducatorGPU.Text = "Producator GPU";
            lblProducatorGPU.Left = 4 * DIMENSIUNE_PAS_X;
            lblProducatorGPU.ForeColor = Color.Black;
            this.Controls.Add((lblProducatorGPU));

            //lblGPU
            lblGPU = new Label();
            lblGPU.Width = LATIME_CONTROL;
            lblGPU.Text = "GPU";
            lblGPU.Left = 5 * DIMENSIUNE_PAS_X;
            lblGPU.ForeColor = Color.Black;
            this.Controls.Add((lblGPU));

            //lblCapacitateRAM
            lblCapacitateRAM = new Label();
            lblCapacitateRAM.Width = LATIME_CONTROL;
            lblCapacitateRAM.Text = "Capacitate RAM";
            lblCapacitateRAM.Left = 6 * DIMENSIUNE_PAS_X;
            lblCapacitateRAM.ForeColor = Color.Black;
            this.Controls.Add((lblCapacitateRAM));

            //lblCapacitateStocare
            lblCapacitateStocare = new Label();
            lblCapacitateStocare.Width = LATIME_CONTROL;
            lblCapacitateStocare.Text = "Capacitate Stocare";
            lblCapacitateStocare.Left = 7 * DIMENSIUNE_PAS_X;
            lblCapacitateStocare.ForeColor = Color.Black;
            this.Controls.Add((lblCapacitateStocare));

            //lblCarcasa
            lblCarcasa = new Label();
            lblCarcasa.Width = LATIME_CONTROL;
            lblCarcasa.Text = "Carcasa";
            lblCarcasa.Left = 8 * DIMENSIUNE_PAS_X;
            lblCarcasa.ForeColor = Color.Black;
            this.Controls.Add((lblCarcasa));

            //lblFrontPanel
            lblFrontPanel = new Label();
            lblFrontPanel.Width = LATIME_CONTROL;
            lblFrontPanel.Text = "Front Panel";
            lblFrontPanel.Left = 9 * DIMENSIUNE_PAS_X;
            lblFrontPanel.ForeColor = Color.Black;
            this.Controls.Add((lblFrontPanel));

            //lblSursa
            lblSursa = new Label();
            lblSursa.Width = LATIME_CONTROL;
            lblSursa.Text = "Sursa";
            lblSursa.Left = 10 * DIMENSIUNE_PAS_X;
            lblSursa.ForeColor = Color.Black;
            this.Controls.Add((lblSursa));


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfisareCalculatoare();
        }

        private void testLabel(Label test)
        {
            Calculator[] calculatoare = adminCalc.GetCalculatoare(out int nrCalculatoare);
            test.Width = LATIME_CONTROL;
            test.Text = calculatoare.Length.ToString();
            test.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(test);
        }

        private void AfisareCalculatoare()
        {
            Calculator[] calculatoare = adminCalc.GetCalculatoare(out int nrCalculatoare);
            Array.Resize(ref calculatoare, nrCalculatoare);
            lblsDenumire = new Label[nrCalculatoare];
            lblsProducator = new Label[nrCalculatoare];
            lblsCPU = new Label[nrCalculatoare];
            lblsProducatorGPU = new Label[nrCalculatoare];
            lblsGPU = new Label[nrCalculatoare];
            lblsCapacitateRAM = new Label[nrCalculatoare];
            lblsCapacitateStocare = new Label[nrCalculatoare];
            lblsCarcasa = new Label[nrCalculatoare];
            lblsFrontPanel = new Label[nrCalculatoare];
            lblsSursa = new Label[nrCalculatoare];



            int i = 0;
            foreach(Calculator calculator in calculatoare)
            {
                lblsDenumire[i] = new Label();
                lblsDenumire[i].Width = LATIME_CONTROL;
                lblsDenumire[i].Text = calculator.denumire;
                lblsDenumire[i].Left = DIMENSIUNE_PAS_X;
                lblsDenumire[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsDenumire[i]);

                lblsProducator[i] = new Label();
                lblsProducator[i].Width = LATIME_CONTROL;
                lblsProducator[i].Text = calculator.producator;
                lblsProducator[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsProducator[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsProducator[i]);

                lblsCPU[i] = new Label();
                lblsCPU[i].Width = LATIME_CONTROL;
                lblsCPU[i].Text = calculator.CPU;
                lblsCPU[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsCPU[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCPU[i]);

                lblsProducatorGPU[i] = new Label();
                lblsProducatorGPU[i].Width = LATIME_CONTROL;
                lblsProducatorGPU[i].Text = calculator.producatorGPU.ToString();
                lblsProducatorGPU[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsProducatorGPU[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsProducatorGPU[i]);

                lblsGPU[i] = new Label();
                lblsGPU[i].Width = LATIME_CONTROL;
                lblsGPU[i].Text = calculator.GPU;
                lblsGPU[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblsGPU[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsGPU[i]);

                lblsCapacitateRAM[i] = new Label();
                lblsCapacitateRAM[i].Width = LATIME_CONTROL;
                lblsCapacitateRAM[i].Text = calculator.capacitateRAM.ToString();
                lblsCapacitateRAM[i].Left = 6 * DIMENSIUNE_PAS_X;
                lblsCapacitateRAM[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCapacitateRAM[i]);

                lblsCapacitateStocare[i] = new Label();
                lblsCapacitateStocare[i].Width = LATIME_CONTROL;
                lblsCapacitateStocare[i].Text = calculator.capacitateStocare.ToString();
                lblsCapacitateStocare[i].Left = 7 * DIMENSIUNE_PAS_X;
                lblsCapacitateStocare[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCapacitateStocare[i]);

                lblsCarcasa[i] = new Label();
                lblsCarcasa[i].Width = LATIME_CONTROL;
                lblsCarcasa[i].Text = calculator.carcasa;
                lblsCarcasa[i].Left = 8 * DIMENSIUNE_PAS_X;
                lblsCarcasa[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCarcasa[i]);

                lblsFrontPanel[i] = new Label();
                lblsFrontPanel[i].Width = LATIME_CONTROL;
                lblsFrontPanel[i].Text = calculator.frontPanel.ToString();
                lblsFrontPanel[i].Left = 9 * DIMENSIUNE_PAS_X;
                lblsFrontPanel[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsFrontPanel[i]);

                lblsSursa[i] = new Label();
                lblsSursa[i].Width = LATIME_CONTROL;
                lblsSursa[i].Text = calculator.sursa.ToString();
                lblsSursa[i].Left = 10 * DIMENSIUNE_PAS_X;
                lblsSursa[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsSursa[i]);
                
                i++;
            }
    }
    }
}
