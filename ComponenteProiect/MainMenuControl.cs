using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using MetroFramework.Controls;
using NivelStocareDate;
using LibrarieModele;


namespace ComponenteProiect
{
    public partial class MainMenuControl: MetroUserControl
    {
        AdministrareUser_FIsierText adminUser;
        AdministrareCalculator_FisierText adminCalculatoare;
        private const string locatieFisierUseri = "C:\\Users\\Mihai\\source\\repos\\ProiectComponente\\ProiectComponente\\bin\\Debug\\Useri.txt";
        private const string locatieFisierCalculatoare = "C:\\Users\\Mihai\\source\\repos\\ProiectComponente\\ProiectComponente\\bin\\Debug\\Calculatoare.txt";

        public MainMenuControl()
        {
            InitializeComponent();
            adminUser = new AdministrareUser_FIsierText(locatieFisierUseri);
            int nrUseri = 0;
            List<User> useri = adminUser.GetUseri(out nrUseri);
            adminCalculatoare = new AdministrareCalculator_FisierText(locatieFisierCalculatoare);
            int nrCalculatoare = 0;
            List<Calculator> calculatoare = adminCalculatoare.GetCalculatoare(out nrCalculatoare);
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
            List<User> useri = adminUser.GetUseri(out nrUseri);
            AfisareUseriGrid(useri);

            int nrCalculatoare = 0;
            List<Calculator> calculatoare = adminCalculatoare.GetCalculatoare(out nrCalculatoare);
            AfisareCalculatoareGrid(calculatoare);

        }

        private void AfiseazaCalculatoare()
        {
            
        }

        private void UserAdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
