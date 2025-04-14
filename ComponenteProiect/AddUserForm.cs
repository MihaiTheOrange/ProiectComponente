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
using LibrarieModele;

namespace ComponenteProiect
{
    public partial class AddUserForm: MetroForm
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private bool validareMetroTextBoxString(MetroTextBox MetroTextBox)
        {
            if (MetroTextBox.Text == "")
            {
                return false;
            }
            if (MetroTextBox.Text.Length < 3)
            {
                return false;
            }
            if (MetroTextBox.Text.Length > 20)
            {
                return false;
            }
            return true;
        }

        private bool validareMetroTextBoxInt(MetroTextBox MetroTextBox)
        {
            if (MetroTextBox.Text == "")
            {
                return false;
            }
            if (!int.TryParse(MetroTextBox.Text, out int result))
            {
                return false;
            }
            if (result < 0)
            {
                return false;
            }
            return true;
        }


        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Telefon_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                User userNou;
                string nume = Nume.Text;
                string prenume = Prenume.Text;
                string email = Email.Text;
                string adresa = Adresa.Text;
                string nrTelefon = Telefon.Text;
                int gen;
                if (GenF.Checked)
                {
                    gen = 2;
                }
                else if (GenM.Checked)
                {
                    gen = 1;
                }
                else
                {
                    gen = 3;
                }
                userNou = new User(nume, prenume, gen, email, adresa, nrTelefon);
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare neasteptata");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GenF_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Nume_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(Nume))
            {
                lBoxNume.ForeColor = Color.Red;
            }
            else
            {
                lBoxNume.ForeColor = Color.Black;
            }
        }

        private void Prenume_TextChanged(object sender, EventArgs e)
        {
            if(!validareMetroTextBoxString(Prenume))
            {
                lBoxPrenume.ForeColor = Color.Red;
            }
            else
            {
                lBoxPrenume.ForeColor = Color.Black;
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(Email))
            {
                lBoxEmail.ForeColor = Color.Red;
            }
            else
            {
                lBoxEmail.ForeColor = Color.Black;
            }
        }

        private void Adresa_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxString(Adresa))
            {
                lBoxAdresa.ForeColor = Color.Red;
            }
            else
            {
                lBoxAdresa.ForeColor = Color.Black;
            }
        }

        private void Telefon_TextChanged(object sender, EventArgs e)
        {
            if (!validareMetroTextBoxInt(Telefon))
            {
                lBoxTelefon.ForeColor = Color.Red;
            }
            else
            {
                lBoxTelefon.ForeColor = Color.Black;
            }
        }
    }
}
