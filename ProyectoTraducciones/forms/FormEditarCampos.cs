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
    public partial class FormEditarCampos : Form
    {
        ListaTraducciones lista;
        Traduccion tradSeleccionada;

        public FormEditarCampos(ListaTraducciones lista, int codigoTraduccion)
        {
            InitializeComponent();
            this.lista = lista;

            CargarDesplegableIdiomas();
            CargarDesplegableTipos();

            //Buscar en el dictionary el codigo de la traducción a editar
            tradSeleccionada = lista.Buscar(codigoTraduccion);

            //Colocar los datos del objeto con su valor en cada control
            codigoTraduccionEditar.Text = tradSeleccionada.Codigo.ToString();
            palabraOriginalEditar.Text = tradSeleccionada.NomOriginal;
            palabraTraducidaEditar.Text = tradSeleccionada.NomTraducida;

            string idioma = tradSeleccionada.Idioma;
            string tipo = tradSeleccionada.Tipo;

            //Obtener index idioma y tipo
            int codIdioma = lista.GetIndexIdioma(idioma);
            int codTipo = lista.GetIndexTipo(tipo);

            dropDownIdiomaEditar.SelectedIndex = codIdioma;
            dropDownTipoEditar.SelectedIndex = codTipo;
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDesplegableIdiomas()
        {
            ListaTraducciones lista = new ListaTraducciones();
            foreach (string linea in lista.CargarListaIdiomas())
            {
                dropDownIdiomaEditar.Items.Add(linea);
            }
        }

        private void CargarDesplegableTipos()
        {
            ListaTraducciones lista = new ListaTraducciones();
            foreach (string linea in lista.CargarListaTipos())
            {
                dropDownTipoEditar.Items.Add(linea);
            }
        }

        private void btnEditarTraduccion_Click(object sender, EventArgs e)
        {
            //Se obtiene la traducción desde el constructor
            Traduccion tradEditar = tradSeleccionada;

            string originalEditar = palabraOriginalEditar.Text;
            string traducidaEditar = palabraTraducidaEditar.Text;

            int indexIdiomaEditar = dropDownIdiomaEditar.SelectedIndex;
            int indexTipoEditar = dropDownTipoEditar.SelectedIndex;

            bool esEditado = lista.Editar(tradEditar,originalEditar,traducidaEditar,indexIdiomaEditar,
                indexTipoEditar,palabraOriginalEditar,palabraTraducidaEditar);

            if (esEditado)
            {
                MessageBox.Show("La traducción se ha editado correctamente", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo algún error durante la edición", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}
