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
    public partial class FormEditar : Form
    {
        ListaTraducciones lista;

        public FormEditar(ListaTraducciones lista)
        {
            InitializeComponent();
            this.lista = lista;

            CargarDesplegableIdiomas();
            CargarDesplegableTipos();

            lista.MostrarTraducciones(listaSeleccionarTraduccionEditar);

            lista.ResetearControlesFormulario(dropDownIdiomaSeleccionarEditar,dropDownTipoSeleccionarEditar,
                nombreTraduccionFiltrar,null);
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDesplegableIdiomas()
        {
            ListaTraducciones lista = new ListaTraducciones();

            foreach (string linea in lista.CargarListaIdiomas())
                dropDownIdiomaSeleccionarEditar.Items.Add(linea);
        }

        private void CargarDesplegableTipos()
        {
            ListaTraducciones lista = new ListaTraducciones();

            foreach (string linea in lista.CargarListaTipos())
                dropDownTipoSeleccionarEditar.Items.Add(linea);
        }

        private void FiltrarTexto(object sender, EventArgs e)
        {
            int indexIdioma = dropDownIdiomaSeleccionarEditar.SelectedIndex;
            int indexTipo = dropDownTipoSeleccionarEditar.SelectedIndex;
            string idioma = lista.GetNomIdioma(indexIdioma);
            string tipo = lista.GetNomTipo(indexTipo);

            if (listaSeleccionarTraduccionEditar != null)
            {
                if (indexIdioma != -1 || indexTipo != -1)
                {
                    listaSeleccionarTraduccionEditar.Items.Clear();
                    foreach (KeyValuePair<int, Traduccion> list in lista.ListaTrads)
                    {
                        if (idioma == list.Value.Idioma && tipo == list.Value.Tipo)
                        {
                            if (string.IsNullOrEmpty(nombreTraduccionFiltrar.Text) == false)
                            {
                                lista.FiltrarPorNombre(list, nombreTraduccionFiltrar, listaSeleccionarTraduccionEditar);
                            }
                            else if (nombreTraduccionFiltrar.Text == "")
                            {
                                listaSeleccionarTraduccionEditar.Items.Clear();
                                lista.MostrarTraducciones(listaSeleccionarTraduccionEditar);
                            }
                        }
                    }
                }
            }
        }

        private void Filtrar(object sender, EventArgs e)
        {
            lista.FiltrarPorIdiomaTipo(dropDownIdiomaSeleccionarEditar,dropDownTipoSeleccionarEditar,listaSeleccionarTraduccionEditar);
        }

        private void btnSeleccionarTraduccionEditar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(listaSeleccionarTraduccionEditar.SelectedItems[0].SubItems[0].Text);

            Form formularioEditar = new FormEditarCampos(lista,codigo);
            formularioEditar.Show();
        }
    }
}
