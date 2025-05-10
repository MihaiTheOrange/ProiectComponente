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
using NivelStocareDate;
using LibrarieModele;

namespace ComponenteProiect
{
    public partial class UserSearch: MetroForm
    {
        public UserSearch()
        {
            InitializeComponent();
        }

        private void UserSearch_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string locatieFisierUseri = StorageFactory.getNumFisUser();
            AdministrareUser_FIsierText admin = new AdministrareUser_FIsierText(locatieFisierUseri);
            User userGasit = admin.CautaUserNume(numeTextbox.Text, prenumeTextbox.Text);
            if (userGasit != null)
            {
                MessageBox.Show("User gasit: " + userGasit.nume + " " + userGasit.prenume + " " + userGasit.gen + " " + userGasit.email +
                    " " + userGasit.adresa + " " + userGasit.nrTelefon);
            }
            else
            {
                MessageBox.Show("Userul nu a fost gasit.");
            }

        }
    }
}
