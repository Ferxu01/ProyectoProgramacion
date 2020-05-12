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
    public partial class FormCrear : Form
    {
        public FormCrear()
        {
            InitializeComponent();
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrarDatos_Click(object sender, EventArgs e)
        {
            palabraOriginal.Clear();
            palabraTraducida.Clear();
            dropDownIdiomaCrear.ResetText();
            dropDownTipoCrear.ResetText();
        }
    }
}
