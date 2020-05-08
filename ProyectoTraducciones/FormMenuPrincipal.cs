using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTraducciones
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private Form formularioActivo = null;
        private void AbrirFormularioHijo(Form formularioHijo)
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
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormCrear());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormEliminar());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormEditar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormBuscar());
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormAyuda());
        }
    }
}
