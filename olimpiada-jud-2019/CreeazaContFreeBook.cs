using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olimpiada_jud_2019
{
    public partial class CreeazaContFreeBook : Form
    {
        List<Utilizator> utilizatori;
        List<Carte> carti;
        List<Imprumut> imprumut;
        public CreeazaContFreeBook(List<Utilizator> utilizatori, List<Carte> carti, List<Imprumut> imprumuturi)
        {
            InitializeComponent();
            this.utilizatori = utilizatori;
            this.carti = carti;
            this.imprumut = imprumuturi;
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            if (txtNume.Text == string.Empty)
            {
                MessageBox.Show("Campul nume obligatoriu!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNume.Focus();
                return;
            }

            if (txtPrenume.Text == string.Empty)
            {
                MessageBox.Show("Campul prenume obligatoriu!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrenume.Focus();
                return;
            }

            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Campul email obligatoriu!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (utilizatori.Any(x => x.email == txtEmail.Text)) 
            {
                MessageBox.Show("Exista deja un utilizator cu acest email", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (txtParola.Text == string.Empty)
            {
                MessageBox.Show("Campul parola obligatoriu!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParola.Focus();
                return;
            }

            if (txtParola.Text != txtParola2.Text)
            {
                MessageBox.Show("Parolele nu coincid!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParola2.Focus();
                txtParola2.Clear();
                return;
            }

            Utilizator u = new Utilizator(txtEmail.Text, txtParola.Text, txtNume.Text, txtPrenume.Text);
            MeniuFreeBook meniu = new MeniuFreeBook(u, utilizatori, carti, imprumut);
            Hide();
            meniu.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) 
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CreeazaContFreeBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
