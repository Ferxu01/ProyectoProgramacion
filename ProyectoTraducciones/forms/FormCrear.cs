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
            foreach (string linea in lista.CargarListaIdiomas())
            {
                dropDownIdiomaCrear.Items.Add(linea);
            }

            dropDownIdiomaCrear.SelectedIndex = 0;
        }

        private void CargarDesplegableTipos(ListaTraducciones lista)
        {
            foreach (string linea in lista.CargarListaTipos())
            {
                dropDownTipoCrear.Items.Add(linea);
            }

            dropDownTipoCrear.SelectedIndex = 0;
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrarDatos_Click(object sender, EventArgs e)
        {
            palabraOriginal.Clear();
            palabraTraducida.Clear();
            dropDownIdiomaCrear.SelectedIndex = 0;
            dropDownTipoCrear.SelectedIndex = 0;
        }

        private void btnAddTraduccion_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            ListaTraducciones listaTrad;

            string original = palabraOriginal.Text;
            string traducida = palabraTraducida.Text;
            int indexIdioma = dropDownIdiomaCrear.SelectedIndex;
            int indexTipo = dropDownTipoCrear.SelectedIndex;

            codigo += 1;

            DialogResult dialogo;
            listaTrad = new ListaTraducciones();

            //Crea el objeto del idioma que se haya elegido y lo añade al diccionario
            if (original != "" && traducida != "" && indexIdioma != null && indexTipo != null)
            {
                listaTrad.Add(listaTrad.SeleccionarIdiomaCrear(indexIdioma, original, traducida, indexTipo, codigo));
                //Ventana de informacion correcta
                dialogo = MessageBox.Show("Traducción creada con éxito","Información");
            }
            else
            {
                //Ventana de error
                dialogo = MessageBox.Show("No se pudo crear la traducción","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
