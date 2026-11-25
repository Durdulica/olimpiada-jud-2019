using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace olimpiada_jud_2019
{
    public partial class MeniuFreeBook : Form
    {
        List<Utilizator> utilizatori;
        List<Carte> carti;
        List<Imprumut> imprumuturi;
        Utilizator utilizator;
        private bool seReincarca = false;

        public MeniuFreeBook(Utilizator utilizator, List<Utilizator> utilizatori, List<Carte> carti, List<Imprumut> imprumuturi)
        {
            InitializeComponent();

            this.utilizatori = utilizatori;
            this.carti = carti;
            this.imprumuturi = imprumuturi;
            this.utilizator = utilizator;

            lblEmail.Text = "Email utilizator: " + utilizator.email;
            IncarcaColoaneImprumutate();
            IncarcaColoaneDisponibile();
            IncarcaColoaneStatistici();

            ReincarcaTablelImprumutate();
            ReincarcaTabelDisponibile();
            ReincarcaTabelStatistici();
        }

        public void IncarcaColoaneImprumutate()
        {
            dgvImprumut.Columns.Clear();
            dgvImprumut.Columns.Add("index", "Index");
            dgvImprumut.Columns.Add("titlu", "Titlu");
            dgvImprumut.Columns.Add("autor", "Autor");
            dgvImprumut.Columns.Add("dataImp", "Data imprumut");
            dgvImprumut.Columns.Add("dataDisp", "Data disponibilitate");

            dgvImprumut.Columns["titlu"].FillWeight = 300;
            foreach(DataGridViewColumn col in dgvImprumut.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void IncarcaColoaneDisponibile()
        {
            dgvDisponibile.Columns.Clear();
            dgvDisponibile.Columns.Add("titlu", "Titlu");
            dgvDisponibile.Columns.Add("autor", "Autor");
            dgvDisponibile.Columns.Add("gen", "Gen");
            dgvDisponibile.Columns.Add("imprumuta", "Imprumuta carte");
        }

        public void IncarcaColoaneStatistici()
        {

        }

        public void ReincarcaTablelImprumutate()
        {
            seReincarca = true;
            dgvImprumut.Rows.Clear();
            List<Imprumut> impUser = imprumuturi.Where(x => x.email == utilizator.email).ToList();
            int rand = 0;

            foreach (Imprumut imp in impUser)
            {
                Carte carte = carti.FirstOrDefault(x => Guid.Equals(x.id_carte, imp.id_carte));
                rand = dgvImprumut.Rows.Add(rand + 1, carte.titlu, carte.autor, 
                    imp.data_imprumut, imp.data_imprumut + 30);

                if(imp.data_imprumut + 30 == "")//???
                {
                    dgvImprumut.Rows[rand].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dgvImprumut.Rows[rand].DefaultCellStyle.BackColor = Color.Green;
                }
            }

            seReincarca = false;
        }

        public void ReincarcaTabelDisponibile()
        {
            seReincarca = true;
            dgvDisponibile.Rows.Clear();
            List<Carte> car = carti.Where(x => imprumuturi.FirstOrDefault(i => i.id_carte == x.id_carte) == null).ToList();
            
            foreach (Carte c in car) 
            {
                int rand = dgvDisponibile.Rows.Add(c.titlu, c.autor, c.gen);    
            }

            seReincarca = false;
        }

        public void ReincarcaTabelStatistici()
        {
            seReincarca = true;

            seReincarca = false;
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

        private void MeniuFreeBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
