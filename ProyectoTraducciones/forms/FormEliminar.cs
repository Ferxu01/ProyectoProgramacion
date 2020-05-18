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
    public partial class FormEliminar : Form
    {
        ListaTraducciones lista;

        public FormEliminar()
        {
            InitializeComponent();
            lista = new ListaTraducciones();

            CargarDesplegableIdiomas(lista);
            CargarDesplegableTipos(lista);

            //MostrarTraducciones(lista);
            
            //Funciona pero no actualiza las creaciones que se hagan porque solo cogen las que se guardaron en los ficheros
            //lista.CargarTraducciones();

            lista.MostrarTraducciones(listaEliminarTraduccion);
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void MostrarTraducciones(ListaTraducciones lista)
        {
            foreach (KeyValuePair<int,Traduccion> list in lista.ListaTrads)
            {
                ListViewItem columna = new ListViewItem(list.Key.ToString());
                columna.SubItems.Add(list.Value.NomOriginal);
                columna.SubItems.Add(list.Value.NomTraducida);
                listaEliminarTraduccion.Items.Add(columna);
            }
        }*/

        private void CargarDesplegableIdiomas(ListaTraducciones lista)
        {
            foreach (string linea in lista.CargarListaIdiomas())
            {
                dropDownIdiomaEliminar.Items.Add(linea);
            }

            dropDownIdiomaEliminar.SelectedIndex = 0;
        }

        private void CargarDesplegableTipos(ListaTraducciones lista)
        {
            foreach (string linea in lista.CargarListaTipos())
            {
                dropDownTipoEliminar.Items.Add(linea);
            }

            dropDownTipoEliminar.SelectedIndex = 0;
        }

        private void btnEliminarTraduccion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
