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
    public partial class FormCandidatosALPAIS : Form
    {
        public FormCandidatosALPAIS()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormCandidatos formCandidatos = new FormCandidatos();
            formCandidatos.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormCandidatos formCandidatos = new FormCandidatos();
            formCandidatos.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormCandidatos formCandidatos = new FormCandidatos();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormCandidatos formCandidatos = new FormCandidatos();
            formCandidatos.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCandidatos formCandidatos = new FormCandidatos();
            formCandidatos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCandidatos formCandidatos = new FormCandidatos();
            formCandidatos.Show();
            this.Hide();
        }

    }
}
