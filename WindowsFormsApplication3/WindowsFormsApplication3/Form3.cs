using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class FormPartidos : Form
    {
        public FormPartidos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCandidatosPRM formCandidatos = new FormCandidatosPRM();
            formCandidatos.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormCandidatosPLD formCandidatos = new FormCandidatosPLD();
            formCandidatos.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCandidatosFP formCandidatos = new FormCandidatosFP();
            formCandidatos.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCandidatosALPAIS formCandidatos = new FormCandidatosALPAIS();
            formCandidatos.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }


    }
}
