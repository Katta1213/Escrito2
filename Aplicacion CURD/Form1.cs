using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;


namespace Aplicacion_CURD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbnInsertar.Checked = true;
            dataGridPersonas.DataSource = ControladorPersona.GetAll();
        }

        private void rbnInsertar_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = rbnInsertar.Checked;

            txtCi.Enabled = !estado;
            txtNombre.Enabled = estado;
            txtApellido.Enabled = estado;
            txtTelefono.Enabled = estado;

            if (!estado) txtCi.Text = "";

        }

        private void rbnActualizar_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = rbnActualizar.Checked;

            txtCi.Enabled = estado;
            txtNombre.Enabled = estado;
            txtApellido.Enabled = estado;
            txtTelefono.Enabled = estado;
        }

        private void rbnEliminar_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = rbnEliminar.Checked;

            txtCi.Enabled = estado;
            txtNombre.Enabled = !estado;
            txtApellido.Enabled = !estado;
            txtTelefono.Enabled = !estado;

            if (!estado) txtNombre.Text = "";
            if (!estado) txtApellido.Text = "";
            if (!estado) txtTelefono.Text = "";
        }

        private void rbnBuscar_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = rbnBuscar.Checked;

            txtCi.Enabled = estado;
            txtNombre.Enabled = estado;
            txtApellido.Enabled = estado;
            txtTelefono.Enabled = estado;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string ci = txtCi.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;

            if (rbnInsertar.Checked)
            {
                try
                {
                    ControladorPersona.Alta(ci, nombre, apellido, telefono);
                    MessageBox.Show("Salio todo gucci");
                }
                catch (Exception)
                {
                    MessageBox.Show("Datos incorrectos");
                }    
            }
            if (rbnActualizar.Checked)
            {
                try
                {
                    ControladorPersona.Modificar(ci, nombre, apellido, telefono);
                    MessageBox.Show("Salio todo gucci");
                }
                catch (Exception)
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
            if (rbnEliminar.Checked)
            {
                try
                {
                    ControladorPersona.Eliminar(ci);
                    MessageBox.Show("Salio todo gucci");
                }
                catch (Exception)
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
            if (rbnBuscar.Checked)
            {
                try
                {
                    dataGridPersonas.DataSource = ControladorPersona.GetSearch(ci, nombre, apellido, telefono);
                    MessageBox.Show("Salio todo gucci");
                }
                catch (Exception)
                {
                    dataGridPersonas.DataSource = ControladorPersona.GetAll();
                }
            }
        }
    }
}
