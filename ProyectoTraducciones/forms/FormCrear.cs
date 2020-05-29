using ProyectoTraducciones.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTraducciones
{
    public partial class FormCrear : Form
    {
        ListaTraducciones lista;
        int codigo;

        public FormCrear(ListaTraducciones lista)
        {
            InitializeComponent();
            this.lista = lista;

            CargarDesplegableIdiomas();
            CargarDesplegableTipos();

            //Obtener el código del último elemento guardado en el dictionary
            codigo = lista.GetCodigoInicial(lista.ListaTrads.Count);
        }

        private void CargarDesplegableIdiomas()
        {
            ListaTraducciones lista = new ListaTraducciones();

            foreach (string linea in lista.CargarListaIdiomas())
                dropDownIdiomaCrear.Items.Add(linea);

            dropDownIdiomaCrear.SelectedIndex = 0;
        }

        private void CargarDesplegableTipos()
        {
            ListaTraducciones lista = new ListaTraducciones();

            foreach (string linea in lista.CargarListaTipos())
                dropDownTipoCrear.Items.Add(linea);

            dropDownTipoCrear.SelectedIndex = 0;
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrarDatos_Click(object sender, EventArgs e)
        {
            lista.ResetearControlesFormulario(dropDownIdiomaCrear,dropDownTipoCrear,palabraOriginal,palabraTraducida);
        }

        private void btnAddTraduccion_Click(object sender, EventArgs e)
        {
            string original = palabraOriginal.Text;
            string traducida = palabraTraducida.Text;
            int indexIdioma = dropDownIdiomaCrear.SelectedIndex;
            int indexTipo = dropDownTipoCrear.SelectedIndex;

            //Crea la traducción elegida y la añade al dictionary
            if ((original != "" && Regex.IsMatch(original, "^[a-zA-Z]{1,}$")) 
                && (traducida != "" && Regex.IsMatch(original, "^[a-zA-Z]{1,}$")))
            {
                codigo += 1;
                lista.Add(lista.SeleccionarIdiomaCrear(indexIdioma, original, traducida, indexTipo, codigo));
                MessageBox.Show("Traducción creada con éxito","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al crear la traducción","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
