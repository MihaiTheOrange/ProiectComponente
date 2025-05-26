using LibrarieModele;
using MetroFramework.Controls;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace ComponenteProiect
{
    public partial class MainMenuControl: MetroUserControl
    {
        AdministrareUser_FIsierText adminUser;
        AdministrareCalculator_FisierText adminCalculatoare;
        private string locatieFisierUseri = StorageFactory.getNumFisUser();
        private string locatieFisierCalculatoare = StorageFactory.getNumFisCalc();

        List<Calculator> calculatoare;
        List<User> useri;
        public MainMenuControl()
        {
            InitializeComponent();
            adminUser = new AdministrareUser_FIsierText(locatieFisierUseri);
            int nrUseri = 0;
            useri = adminUser.GetUseri(out nrUseri);
            adminCalculatoare = new AdministrareCalculator_FisierText(locatieFisierCalculatoare);
            int nrCalculatoare = 0;
            calculatoare = adminCalculatoare.GetCalculatoare(out nrCalculatoare);
            AfisareUseriGrid(useri);
            AfisareCalculatoareGrid(calculatoare);

            CalculatoareGrid.Style = MetroFramework.MetroColorStyle.Green;
            CalculatoareGrid.EnableHeadersVisualStyles = false;
            CalculatoareGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 167, 69); // Green
            CalculatoareGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //CalculatoareGrid.BackgroundColor = Color.White;
            //CalculatoareGrid.DefaultCellStyle.BackColor = Color.White;
            CalculatoareGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            CalculatoareGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CalculatoareGrid.RowHeadersVisible = false;
            CalculatoareGrid.ReadOnly = true;

            UsersGrid.Style = MetroFramework.MetroColorStyle.Green;
            UsersGrid.EnableHeadersVisualStyles = false;
            UsersGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 167, 69); // Green
            UsersGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //UsersGrid.BackgroundColor = Color.White;
            //UsersGrid.DefaultCellStyle.BackColor = Color.White;

            UsersGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
           
            UsersGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UsersGrid.RowHeadersVisible = false;
            UsersGrid.ReadOnly = true;
        }


        private void MainMenuControl_Load(object sender, EventArgs e)
        {
            calculatoare = adminCalculatoare.GetCalculatoare(out int nrCalculatoare);
            useri = adminUser.GetUseri(out int nrUseri);
            AfisareUseriGrid(useri);
            AfisareCalculatoareGrid(calculatoare);
        }

        private void AfisareCalculatoareGrid(List<Calculator> calculatoare)
        { //string _denumire, string _producator, string _CPU, int _producatorGPU, string _GPU,
          //int _capacitateRAM, int _capacitateStocare, string _carcasa, string _frontPanel, int _sursa
            CalculatoareGrid.DataSource = calculatoare.Select(c => new
            {
                c.denumire,
                c.producator,
                c.CPU,
                c.GPU,
                c.capacitateRAM,
                IdUser = c.IdUser == -1 ? "Disponibil" : c.IdUser.ToString()
            }).ToList();
        }

        private void AfisareUseriGrid(List<User> useri)
        {
            UsersGrid.DataSource = useri.Select(u => new
            {
                u.nume,
                u.prenume,
                u.email,
                u.nrTelefon,
                u.gen
            }).ToList();
        }
        public void refreshGrids()
        {
            int nrUseri = 0;
            useri = adminUser.GetUseri(out nrUseri);
            AfisareUseriGrid(useri);

            int nrCalculatoare = 0;
            calculatoare = adminCalculatoare.GetCalculatoare(out nrCalculatoare);
            AfisareCalculatoareGrid(calculatoare);

        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            int indexCalc = CalculatoareGrid.CurrentRow?.Index ?? -1;
            int indexUser = UsersGrid.CurrentRow?.Index ?? -1;
            if (indexCalc == -1 || indexUser == -1)
            {
                MessageBox.Show("Selectati un calculator si un utilizator pentru a face o comanda!");
                return;
            }
            Calculator calculatorSelectat = calculatoare[indexCalc];
            User userSelectat = useri[indexUser];
            
            if (calculatorSelectat.IdUser != -1)
            {
                MessageBox.Show("Calculatorul este deja comandat!");
                return;
            }

            calculatorSelectat.IdUser = userSelectat.IdUser;
            adminCalculatoare.EditCalculator(calculatorSelectat);
            
            calculatoare = adminCalculatoare.GetCalculatoare(out int nrCalculatoare);
            AfisareCalculatoareGrid(calculatoare);
        }


    }
}
