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


    public partial class FormCandidatos : Form
    {
        private HashSet<long> cedulasRegistradas = new HashSet<long>();

        public FormCandidatos()
        {
            InitializeComponent();

            // Configurar el DataGridView para que no permita agregar filas manualmente
            dgvResultados.AllowUserToAddRows = false;

            // Configurar las columnas del DataGridView como de solo lectura
            foreach (DataGridViewColumn column in dgvResultados.Columns)
            {
                column.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Variables para almacenar la edad y la cédula
            int edad;
            long cedula;

            // Validar que el nombre no contenga caracteres especiales
            if (!EsNombreValido(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre válido.", "Error de Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que la cédula sea un número válido y tenga exactamente 11 dígitos
            if (!long.TryParse(txtCedula.Text, out cedula) || txtCedula.Text.Length != 11)
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido con exactamente 11 dígitos.", "Error de Cédula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que la cédula no se haya registrado previamente
            if (cedulasRegistradas.Contains(cedula))
            {
                MessageBox.Show("La cédula ingresada ya ha sido registrada.", "Error de Cédula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que la edad sea un número válido y mayor o igual a 18
            if (!int.TryParse(txtEdad.Text, out edad) || edad < 18)
            {
                MessageBox.Show("Por favor, ingrese una edad válida mayor o igual a 18.", "Error de Edad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar la información del votante al DataGridView
            dgvResultados.Rows.Add(new object[] { txtNombre.Text, cedula, edad });

            // Agregar la cédula a la lista de cédulas registradas
            cedulasRegistradas.Add(cedula);

            // Limpiar los campos después de registrar
            LimpiarCampos();
        }

        private bool EsNombreValido(string nombre)
        {
            return nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCedula.Clear();
            txtEdad.Clear();
        }
    }
}