using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using NivelStocareDate;
using LibrarieModele;

namespace ComponenteProiect
{
    public partial class CalculatoareAdminControl: MetroUserControl
    {
        AdministrareCalculator_FisierText adminCalculatoare;
        private string locatieFisierCalculatoare = StorageFactory.getNumFisCalc();
        List<Calculator> calculatoare;
        public CalculatoareAdminControl()
        {
            InitializeComponent();
            

            CalculatoareAdminGrid.Style = MetroFramework.MetroColorStyle.Green;
            CalculatoareAdminGrid.EnableHeadersVisualStyles = false;
            CalculatoareAdminGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 167, 69); // Green
            CalculatoareAdminGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //CalculatoareAdminGrid.BackgroundColor = Color.White;
            //CalculatoareAdminGrid.DefaultCellStyle.BackColor = Color.White;
            CalculatoareAdminGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            CalculatoareAdminGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CalculatoareAdminGrid.RowHeadersVisible = false;
            CalculatoareAdminGrid.ReadOnly = true;

            adminCalculatoare = new AdministrareCalculator_FisierText(locatieFisierCalculatoare);
            int nrCalculatoare = 0;
            calculatoare = adminCalculatoare.GetCalculatoare(out nrCalculatoare);
            AfisareCalculatoareGrid(calculatoare);

        }

        public void AfisareCalculatoareGrid(List<Calculator> calculatoare)
        {
            CalculatoareAdminGrid.DataSource = calculatoare.Select(c => new
            {
                c.denumire,
                c.producator,
                c.CPU,
                c.producatorGPU,
                c.GPU,
                c.capacitateRAM,
                c.capacitateStocare,
                c.carcasa,
                c.frontPanel,
                c.sursa
            }).ToList();
        }
        public void refreshGrid()
        {
            int nrCalculatoare = 0;
            calculatoare = adminCalculatoare.GetCalculatoare(out nrCalculatoare);
            AfisareCalculatoareGrid(calculatoare);
        }

        private void CalculatoareAdminControl_Load(object sender, EventArgs e)
        {
            calculatoare = adminCalculatoare.GetCalculatoare(out int nrCalculatoare);
            AfisareCalculatoareGrid(calculatoare);
        }

        private void CalculatoareAdminGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void SearchCalc_Click(object sender, EventArgs e)
        {
            CalculatoareSearch searchCalculatorForm = new CalculatoareSearch(this);
            searchCalculatorForm.ShowDialog();
        }

        private void AddCalc_Click(object sender, EventArgs e)
        {
            AddCalculatorForm addCalculatorForm = new AddCalculatorForm(this);
            addCalculatorForm.ShowDialog();
        }

        private void DeleteCalc_Click_1(object sender, EventArgs e)
        {

        }

        private void EditCalc_Click(object sender, EventArgs e)
        {
            int index = CalculatoareAdminGrid.CurrentRow?.Index ?? -1;
            if (index>=0)
            {
                Calculator selectedCalc = calculatoare[index];
                EditCalculatorForm editCalculatorForm = new EditCalculatorForm(selectedCalc, this);
                editCalculatorForm.ShowDialog();
            }
            
        }
    }
}
    