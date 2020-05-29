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

            CargarDesplegableIdiomas();
            CargarDesplegableTipos();

            lista.MostrarTraducciones(listaMostrarTraduccionBuscada);

            lista.ResetearControlesFormulario(dropDownIdiomaBuscar,dropDownTipoBuscar,nombreOriginalTraduccionBuscar,null);
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDesplegableIdiomas()
        {
            ListaTraducciones lista = new ListaTraducciones();

            foreach (string linea in lista.CargarListaIdiomas())
                dropDownIdiomaBuscar.Items.Add(linea);
        }

        private void CargarDesplegableTipos()
        {
            ListaTraducciones lista = new ListaTraducciones();

            foreach (string linea in lista.CargarListaTipos())
                dropDownTipoBuscar.Items.Add(linea);
        }

        private void btnBuscarTraduccion_Click(object sender, EventArgs e)
        {
            //Filtro de búsqueda por desplegables
            int indexIdioma = dropDownIdiomaBuscar.SelectedIndex;
            string idioma = lista.GetNomIdioma(indexIdioma);
            int indexTipo = dropDownTipoBuscar.SelectedIndex;
            string tipo = lista.GetNomTipo(indexTipo);

            if (listaMostrarTraduccionBuscada != null)
            {
                if (indexIdioma != -1 || indexTipo != -1)
                {
                    listaMostrarTraduccionBuscada.Items.Clear();
                    foreach (KeyValuePair<int,Traduccion> list in lista.ListaTrads)
                    {
                        if (idioma == list.Value.Idioma && tipo == list.Value.Tipo)
                        {
                            //Filtro de búsqueda de texto
                            if (string.IsNullOrEmpty(nombreOriginalTraduccionBuscar.Text) == false)
                            {
                                lista.FiltrarPorNombre(list,nombreOriginalTraduccionBuscar,listaMostrarTraduccionBuscada);
                            }
                            else if (nombreOriginalTraduccionBuscar.Text == "")
                            {
                                listaMostrarTraduccionBuscada.Items.Clear();
                                lista.MostrarTraducciones(listaMostrarTraduccionBuscada);
                            }
                        }
                    }
                }
            }
        }
    }
}
