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

            CargarDesplegableIdiomas();
            CargarDesplegableTipos();

            lista.MostrarTraducciones(listaEliminarTraduccion);

            lista.ResetearControlesFormulario(dropDownIdiomaEliminar,dropDownTipoEliminar,null,null);
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDesplegableIdiomas()
        {
            ListaTraducciones lista = new ListaTraducciones();

            foreach (string linea in lista.CargarListaIdiomas())
                dropDownIdiomaEliminar.Items.Add(linea);
        }

        private void CargarDesplegableTipos()
        {
            ListaTraducciones lista = new ListaTraducciones();

            foreach (string linea in lista.CargarListaTipos())
                dropDownTipoEliminar.Items.Add(linea);
        }

        private void btnEliminarTraduccion_Click(object sender, EventArgs e)
        {
            //Obtener el código del elemento seleccionado de la listView
            int codigo = Convert.ToInt32(listaEliminarTraduccion.SelectedItems[0].SubItems[0].Text);

            lista.Borrar(codigo);

            //Mostrar la listView con elementos actualizados
            listaEliminarTraduccion.Items.Clear();
            lista.MostrarTraducciones(listaEliminarTraduccion);
            lista.ResetearControlesFormulario(dropDownIdiomaEliminar,dropDownTipoEliminar,null,null);
        }

        private void Filtrar(object sender, EventArgs e)
        {
            lista.FiltrarPorIdiomaTipo(dropDownIdiomaEliminar,dropDownTipoEliminar,listaEliminarTraduccion);
        }
    }
}
