using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using MetroFramework.Controls;

namespace ComponenteProiect
{
    public partial class UsersForm: MetroForm
    {
        MetroForm mainForm;
        public UsersForm(MetroForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
            mainForm.BringToFront();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            UserSearch userSearch = new UserSearch();
            userSearch.ShowDialog();
        }
    }
}
