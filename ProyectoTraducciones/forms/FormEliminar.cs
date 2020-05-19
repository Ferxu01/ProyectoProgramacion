using ProyectoTraducciones.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTraducciones
{
    public partial class FormEliminar : Form
    {
        ListaTraducciones lista;

        public FormEliminar(ListaTraducciones lista)
        {
            InitializeComponent();
            this.lista = lista;

            CargarDesplegableIdiomas(lista);
            CargarDesplegableTipos(lista);

            //Carga las traducciones que se encuentran en el dictionary
            lista.MostrarTraducciones(listaEliminarTraduccion);
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDesplegableIdiomas(ListaTraducciones lista)
        {
            foreach (string linea in lista.CargarListaIdiomas())
            {
                dropDownIdiomaEliminar.Items.Add(linea);
            }
        }

        private void CargarDesplegableTipos(ListaTraducciones lista)
        {
            foreach (string linea in lista.CargarListaTipos())
            {
                dropDownTipoEliminar.Items.Add(linea);
            }
        }

        private void btnEliminarTraduccion_Click(object sender, EventArgs e)
        {
            //Obtener el campo código del elemento seleccionado
            int codigo = Convert.ToInt32(listaEliminarTraduccion.SelectedItems[0].SubItems[0].Text);

            lista.Borrar(codigo); //Borrar el elemento seleccionado del dictionary

            //Método que actualice el dictionary de lista traducciones
            listaEliminarTraduccion.Items.Clear();
            lista.MostrarTraducciones(listaEliminarTraduccion);
        }
    }
}
