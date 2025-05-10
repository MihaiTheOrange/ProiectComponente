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
using LibrarieModele;
using NivelStocareDate;

namespace ComponenteProiect
{
    public partial class UserAdminControl: MetroUserControl
    {
        AdministrareUser_FIsierText adminUser;
        private const string locatieFisierUseri = "C:\\Users\\Mihai\\source\\repos\\ProiectComponente\\ProiectComponente\\bin\\Debug\\Useri.txt";
       
        public UserAdminControl()
        {
            InitializeComponent();
            
            UserAdminGrid.Style = MetroFramework.MetroColorStyle.Green;
            UserAdminGrid.EnableHeadersVisualStyles = false;
            UserAdminGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 167, 69); // Green
            UserAdminGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //UserAdminGrid.BackgroundColor = Color.White;
            //UserAdminGrid.DefaultCellStyle.BackColor = Color.White;
            UserAdminGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            UserAdminGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UserAdminGrid.RowHeadersVisible = false;
            UserAdminGrid.ReadOnly = true;


            adminUser = new AdministrareUser_FIsierText(locatieFisierUseri);
            int nrUseri = 0;
            List<User> useri = adminUser.GetUseri(out nrUseri);
            AfisareUseriGrid(useri);
        }
        private void AfisareUseriGrid(List<User> useri)
        {
            UserAdminGrid.DataSource = useri.Select(u => new
            {
                u.nume,
                u.prenume,
                u.email,
                u.nrTelefon,
                u.gen
            }).ToList();
        }
        public void refreshGrid()
        {
            int nrUseri = 0;
            List<User> useri = adminUser.GetUseri(out nrUseri);
            AfisareUseriGrid(useri);
        }

        private void UserAdminControl_Load(object sender, EventArgs e)
        {

        }

        private void UserAdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void SearchUser_Click(object sender, EventArgs e)
        {
            UserSearch userSearch = new UserSearch();
            userSearch.ShowDialog();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {

        }
    }
}
