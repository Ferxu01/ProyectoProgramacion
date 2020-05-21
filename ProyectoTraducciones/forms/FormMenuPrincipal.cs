using ProyectoTraducciones.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTraducciones
{
    public partial class MenuPrincipal : Form
    {
        ListaTraducciones lista;

        public MenuPrincipal()
        {
            InitializeComponent();
            lista = new ListaTraducciones();
        }

        private Form formularioActivo = null;
        public void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(formularioHijo);
            panelFormularioHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //Se cargan las traducciones de los ficheros
            lista.CargarTraducciones();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormCrear(lista));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormEliminar(lista));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormEditar(lista));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormBuscar(lista));
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormAyuda());
        }

        private void GuardarDatos(object sender, FormClosingEventArgs e)
        {
            DialogResult ventana = MessageBox.Show("¿Está seguro de que quiere cerrar el programa?", "Cerrar",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (ventana == DialogResult.OK)
            {
                lista.GuardarTraducciones();
            }
            else
            {
                if (ventana == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
