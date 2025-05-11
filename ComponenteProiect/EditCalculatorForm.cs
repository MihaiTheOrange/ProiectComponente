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
using MetroFramework.Forms;
using NivelStocareDate;

namespace ComponenteProiect
{
    public partial class EditCalculatorForm: MetroForm
    {
        AdministrareCalculator_FisierText adminCalc;
        int idCalcNou;
        Calculator calcNou;
        public EditCalculatorForm(Calculator calculator)
        {
            adminCalc = new AdministrareCalculator_FisierText(StorageFactory.getNumFisCalc());
            InitializeComponent();
            initFields(calculator);
            idCalcNou = calculator.IdCalculator;
            calcNou = calculator;
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

        private void initRadio(Calculator calculator)
        {
            nvidiaRad.Checked = false;
            amdRad.Checked = false;
            intelRad.Checked = false;
            qualcommRad.Checked = false;
            otherRad.Checked = false;
            if (calculator.producatorGPU == ProducatorGPU.Nvidia)
                nvidiaRad.Checked = true;
            else if (calculator.producatorGPU == ProducatorGPU.AMD)
                amdRad.Checked = true;
            else if (calculator.producatorGPU == ProducatorGPU.Intel)
                intelRad.Checked = true;
            else if (calculator.producatorGPU == ProducatorGPU.Qualcomm)
                qualcommRad.Checked = true;
            else
                otherRad.Checked = true;
        }

        private void initCheckbox(Calculator calculator)
        {
            usb2chk.Checked = false;
            usb3chk.Checked = false;
            usb3_1chk.Checked = false;
            usbcchk.Checked = false;
            thunderboltchk.Checked = false;
            jack2_5chk.Checked = false;
            jack3_5chk.Checked = false;
            jack6_35chk.Checked = false;
            if (calculator.frontPanel.HasFlag(FrontPanel.USB2))
                usb2chk.Checked = true;
            if (calculator.frontPanel.HasFlag(FrontPanel.USB3))
                usb3chk.Checked = true;
            if (calculator.frontPanel.HasFlag(FrontPanel.USB3_1))
                usb3_1chk.Checked = true;
            if (calculator.frontPanel.HasFlag(FrontPanel.USBC))
                usbcchk.Checked = true;
            if (calculator.frontPanel.HasFlag(FrontPanel.Thunderbolt))
                thunderboltchk.Checked = true;
            if (calculator.frontPanel.HasFlag(FrontPanel.Jack2_5))
                jack2_5chk.Checked = true;
            if (calculator.frontPanel.HasFlag(FrontPanel.Jack3_5))
                jack3_5chk.Checked = true;
            if (calculator.frontPanel.HasFlag(FrontPanel.Jack6_35))
                jack6_35chk.Checked = true;
        }

        private void initFields(Calculator calculator)
        {
            Denumire.Text = calculator.denumire;
            Producator.Text = calculator.producator;
            CPU.Text = calculator.CPU;
            GPU.Text = calculator.GPU;
            RAM.Text = calculator.capacitateRAM.ToString();
            Stocare.Text = calculator.capacitateStocare.ToString();
            Carcasa.Text = calculator.carcasa;
            Sursa.Text = calculator.sursa.ToString();

            initRadio(calculator);
            initCheckbox(calculator);

        }

        private void EditCalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCalc_Click(object sender, EventArgs e)
        {
            try
            {
                calcNou.denumire = Denumire.Text;
                calcNou.producator = Producator.Text;
                calcNou.CPU = CPU.Text;
                calcNou.GPU = GPU.Text;
                calcNou.capacitateRAM = int.Parse(RAM.Text);
                calcNou.capacitateStocare = int.Parse(Stocare.Text);
                calcNou.carcasa = Carcasa.Text;
                calcNou.sursa = int.Parse(Sursa.Text);
                calcNou.producatorGPU = (ProducatorGPU)getProducatorGPU();
                calcNou.frontPanel = (FrontPanel)Enum.Parse(typeof(FrontPanel), getFrontPanel());


                adminCalc.EditCalculator(calcNou);
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Eroare neasteptata");
            }
        }
    }
}
