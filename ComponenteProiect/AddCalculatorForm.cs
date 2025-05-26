using LibrarieModele;
using MetroFramework.Forms;
using NivelStocareDate;
using System;
using System.Windows.Forms;

namespace ComponenteProiect
{
    public partial class AddCalculatorForm: MetroForm
    {
        AdministrareCalculator_FisierText adminCalc;
        int nrCalculatoare = 0;
        CalculatoareAdminControl originalControl;
        string locatieFisierCalculatoare = StorageFactory.getNumFisCalc();
        public AddCalculatorForm(CalculatoareAdminControl originalControl)
        {
            InitializeComponent();
            adminCalc = new AdministrareCalculator_FisierText(StorageFactory.getNumFisCalc());
            adminCalc.GetCalculatoare(out nrCalculatoare);
            this.originalControl = originalControl;
        }

        private int getProducatorGPU()
        {
            if (nvidiaRad.Checked)
                return (int)ProducatorGPU.Nvidia;
            else if (amdRad.Checked)
                return (int)ProducatorGPU.AMD;
            else if (intelRad.Checked)
                return (int)ProducatorGPU.Intel;
            else if (qualcommRad.Checked)
                return (int)ProducatorGPU.Qualcomm;
            else
                return (int)ProducatorGPU.Other;

        }

        private string getFrontPanel()
        {
            FrontPanel frontPanel = FrontPanel.None;
            if (usb2chk.Checked)
            {
                frontPanel |= FrontPanel.USB2;
            }
            if (usb3chk.Checked)
            {
                frontPanel |= FrontPanel.USB3;
            }
            if (usb3_1chk.Checked)
            {
                frontPanel |= FrontPanel.USB3_1;
            }
            if (usbcchk.Checked)
            {
                frontPanel |= FrontPanel.USBC;
            }
            if (thunderboltchk.Checked)
            {
                frontPanel |= FrontPanel.Thunderbolt;
            }
            if (jack2_5chk.Checked)
            {
                frontPanel |= FrontPanel.Jack2_5;
            }
            if (jack3_5chk.Checked)
            {
                frontPanel |= FrontPanel.Jack3_5;
            }
            if (jack6_35chk.Checked)
            {
                frontPanel |= FrontPanel.Jack6_35;
            }
            return frontPanel.ToString();
        }

        private void AddCalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCalc_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(locatieFisierCalculatoare);
                Calculator calculatorNou;
                string denumire = Denumire.Text;
                string producator = Producator.Text;
                string CPU = this.CPU.Text;

                string GPU = this.GPU.Text;
                int capacitateRAM = int.Parse(RAM.Text);
                int capacitateStocare = int.Parse(Stocare.Text);
                string carcasa = Carcasa.Text;

                int sursa = int.Parse(Sursa.Text);

                int producatorGPU = getProducatorGPU();
                string frontPanel = getFrontPanel();


                calculatorNou = new Calculator(denumire, producator, CPU, producatorGPU, GPU, capacitateRAM, capacitateStocare, carcasa, frontPanel, sursa);

                adminCalc.GetCalculatoare(out int nrCalculatoare);

                adminCalc.AddCalculator(calculatorNou, ref nrCalculatoare);
                
                MessageBox.Show("Calculator adaugat cu succes!");
                originalControl.refreshGrid();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare neasteptata");
            }
        }

    }
}
