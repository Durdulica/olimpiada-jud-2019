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
    public partial class LogareFreeBook : Form
    {
        List<Utilizator> utilizatori;
        public LogareFreeBook(string cale)
        {
            InitializeComponent();
            utilizatori = Date.CitesteUtilizatori(cale);
        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Campul email obligatoriu!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (txtParola.Text == string.Empty)
            {
                MessageBox.Show("Campul parola obligatoriu!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParola.Focus();
                return;
            }

            Utilizator u = utilizatori.FirstOrDefault(x => x.email == txtEmail.Text);
            if (u == null || u.parola != txtParola.Text)
            {
                MessageBox.Show("Eroare autentificare!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParola.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtEmail.Focus();
                return;
            }

            MeniuFreeBook meniu = new MeniuFreeBook(u);
            Hide();
            meniu.Show();
        }

        private void LogareFreeBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
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
    }
}
