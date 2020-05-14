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
    public partial class FormCrear : Form
    {
        public FormCrear()
        {
            InitializeComponent();
            ListaTraducciones lista = new ListaTraducciones();

            CargarDesplegableIdiomas(lista);
            CargarDesplegableTipos(lista);
        }

        private void CargarDesplegableIdiomas(ListaTraducciones lista)
        {
            foreach (KeyValuePair<int, string> list in lista.CargarListaIdiomas())
            {
                dropDownIdiomaCrear.Items.Add(list.Value);
            }
        }

        private void CargarDesplegableTipos(ListaTraducciones lista)
        {
            foreach (KeyValuePair<int,string> list in lista.CargarListaTipos())
            {
                dropDownTipoCrear.Items.Add(list.Value);
            }
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

        private void btnAddTraduccion_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            Traduccion traduccionCrear;
            ListaTraducciones listaTrad;

            string original = palabraOriginal.Text;
            string traducida = palabraTraducida.Text;
            int indexIdioma = dropDownIdiomaCrear.SelectedIndex;
            int indexTipo = dropDownTipoCrear.SelectedIndex;

            codigo += 1;

            traduccionCrear = new TraduccionIngles(codigo,original,traducida,indexIdioma,indexTipo);
            listaTrad = new ListaTraducciones();
            listaTrad.Add(traduccionCrear);


        }
    }
}
