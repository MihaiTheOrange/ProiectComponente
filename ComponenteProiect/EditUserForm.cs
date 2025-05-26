using LibrarieModele;
using MetroFramework.Forms;
using NivelStocareDate;
using System;
using System.Windows.Forms;

namespace ComponenteProiect
{
    public partial class EditUserForm : MetroForm
    {
        AdministrareUser_FIsierText adminUser;
        int idUserNou;
        User userNou;
        UserAdminControl originalControl;
        public EditUserForm(User user, UserAdminControl originalControl)
        {
            InitializeComponent();
            this.originalControl = originalControl;
            adminUser = new AdministrareUser_FIsierText(StorageFactory.getNumFisUser());
            idUserNou = user.IdUser;
            userNou = user;
            initFields();
        }
        private void initFields()
        {
            Nume.Text = userNou.nume;
            Prenume.Text = userNou.prenume;

            Email.Text = userNou.email;
            Adresa.Text = userNou.adresa;
            Telefon.Text = userNou.nrTelefon;

            if (userNou.gen == GenUser.Masculin)
                GenM.Checked = true;
            else if (userNou.gen == GenUser.Feminin)
                GenF.Checked = true;
            else
                GenN.Checked = true;
        }
        private void EditUserForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            try
            {
                userNou.nume = Nume.Text;
                userNou.prenume = Prenume.Text;
                userNou.email = Email.Text;
                userNou.adresa = Adresa.Text;
                userNou.nrTelefon = Telefon.Text;
                if (GenM.Checked)
                    userNou.gen = GenUser.Masculin;
                else if (GenF.Checked)
                    userNou.gen = GenUser.Feminin;
                else
                    userNou.gen = GenUser.Altul;
                adminUser.EditUser(userNou, idUserNou);
                MessageBox.Show("Utilizator editat cu succes!");
                originalControl.refreshGrid();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare Neasteptata");
            }
        }
    }
}
