using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNombre.Text.Trim() == "")
                {
                    throw new Exception("Debe ingresar el nombre");
                }

                int edad;

                if (!int.TryParse(textBoxEdad.Text, out edad))
                {
                    throw new Exception("La edad debe ser numérica");
                }

                if (!textBoxGmail.Text.Contains("@"))
                {
                    throw new Exception("Correo inválido");
                }

                if (!textBoxGmail.Text.EndsWith("@gmail.com"))
                {
                    throw new Exception("Debe ser un correo Gmail");
                }

                long telefono;

                if (!long.TryParse(textBoxTelefono.Text, out telefono))
                {
                    throw new Exception("El teléfono debe contener números");
                }

                MessageBox.Show("Estudiante registrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxEdad.Clear();
            textBoxGmail.Clear();
            textBoxTelefono.Clear();

            textBoxNombre.Focus();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
