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
        private string locatieFisierUseri = StorageFactory.getNumFisUser();
        List<User> useri;
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
            useri = adminUser.GetUseri(out nrUseri);
            AfisareUseriGrid(useri);
        }
        public void AfisareUseriGrid(List<User> useri)
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
            useri = adminUser.GetUseri(out nrUseri);
            AfisareUseriGrid(useri);
        }

        private void UserAdminControl_Load(object sender, EventArgs e)
        {
            useri = adminUser.GetUseri(out int nrUseri);
            AfisareUseriGrid(useri);
        }

        private void UserAdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(this);
            addUserForm.ShowDialog();
        }

        private void SearchUser_Click(object sender, EventArgs e)
        {
            UserSearch userSearch = new UserSearch(this);
            userSearch.ShowDialog();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            int index = UserAdminGrid.CurrentRow?.Index ?? -1;
            if (index >= 0)
            {
                User user = useri[index];
                EditUserForm editUserForm = new EditUserForm(user, this);
                editUserForm.ShowDialog();

                //EditUserForm editUserForm = new EditUserForm();
            }
        }
    }
}
