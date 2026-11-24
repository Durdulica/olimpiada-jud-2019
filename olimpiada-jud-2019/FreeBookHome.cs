using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olimpiada_jud_2019
{
    public partial class FreeBookHome : Form
    {
        List<Utilizator> utilizatori = new List<Utilizator>();
        List<Carte> carti = new List<Carte>();
        List<Imprumut> imprumuturi = new List<Imprumut>();
        readonly string path = Path.Combine(Application.StartupPath, "..", "..", "..", "csarp");

        public FreeBookHome()
        {
            InitializeComponent();
            utilizatori = Date.CitesteUtilizatori(path);
            carti = Date.CitesteCarti(path);
            imprumuturi = Date.CitesteImprumuturi(path, carti);
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            CreeazaContFreeBook creeazaCont = new CreeazaContFreeBook(utilizatori, carti, imprumuturi);
            Hide();
            creeazaCont.Show();
            return;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            LogareFreeBook logare = new LogareFreeBook(utilizatori, carti, imprumuturi);
            Hide();
            logare.Show();
            return;
        }
    }
}
