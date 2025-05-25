using LibrarieModele;
using MetroFramework.Forms;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ComponenteProiect
{
    public partial class CalculatoareSearch: MetroForm
    {
        CalculatoareAdminControl originalControl;
        AdministrareCalculator_FisierText adminCalc;
        int nrCalculatoare = 0;
        public CalculatoareSearch( CalculatoareAdminControl originalControl)
        {
            this.originalControl = originalControl;
            InitializeComponent();
            adminCalc = new AdministrareCalculator_FisierText(StorageFactory.getNumFisCalc());

        }

        private void CalculatoareSearch_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string denumire = denumireTextBox.Text;
            Calculator calculatorGasit = adminCalc.CautaCalculatorDenumire(denumire);
            if (calculatorGasit != null)
            {
                List<Calculator> listaGasit = new List<Calculator> { calculatorGasit };
                originalControl.AfisareCalculatoareGrid(listaGasit);
                this.Close();
            }
            else
            {
                MessageBox.Show("Calculatorul nu a fost gasit.");
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
