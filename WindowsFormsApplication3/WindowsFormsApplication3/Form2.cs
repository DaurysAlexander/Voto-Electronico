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
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click2_Click(object sender, EventArgs e)
        {
            FormPartidos formPartidos = new FormPartidos();
            formPartidos.Show();
            this.Hide();
        }
    }
}
