using System.Windows.Forms;

namespace olimpiada_jud_2019
{
    public partial class MeniuFreeBook : Form
    {
        public MeniuFreeBook(Utilizator utilizator)
        {
            InitializeComponent();
            lblEmail.Text = "Email utilizator: " + utilizator.email;
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
    }
}
