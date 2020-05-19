using ProyectoTraducciones.clases;
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
    public partial class FormBuscar : Form
    {
        ListaTraducciones lista;
        public FormBuscar(ListaTraducciones lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
