using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTraducciones.clases
{
    public class ListaTraducciones
    {
        Dictionary<int,Traduccion> listaTraducciones;
        ArrayList listaTipos;
        ArrayList listaIdiomas;

        public ListaTraducciones()
        {
            listaTraducciones = new Dictionary<int,Traduccion>();

            //Listas para cargar los desplegables
            listaTipos = new ArrayList();
            listaIdiomas = new ArrayList();
        }

        public void MostrarTraducciones(ListView listaEliminarTraduccion)
        {
            foreach (KeyValuePair<int,Traduccion> list in listaTraducciones)
            {
                ListViewItem columna = new ListViewItem(list.Key.ToString());
                columna.SubItems.Add(list.Value.NomOriginal);
                columna.SubItems.Add(list.Value.NomTraducida);
                listaEliminarTraduccion.Items.Add(columna);
            }
        }

        public void Add(Traduccion traduccion)
        {
            listaTraducciones.Add(traduccion.Codigo,traduccion);
        }

        public bool Borrar(int codigo)
        {
            return listaTraducciones.Remove(codigo);
        }

        public bool Editar(Traduccion traduccion, string original, string traducida, int indexIdioma, int indexTipo,
            TextBox originalEditar, TextBox traducidaEditar)
        {
            if (original != traduccion.NomOriginal
                || traducida != traduccion.NomTraducida
                || GetNomIdioma(indexIdioma) != traduccion.Idioma
                || GetNomTipo(indexTipo) != traduccion.Tipo)
            {
                traduccion.NomOriginal = originalEditar.Text;
                traduccion.NomTraducida = traducidaEditar.Text;
                traduccion.Idioma = GetNomIdioma(indexIdioma);
                traduccion.Tipo = GetNomTipo(indexTipo);

                return true;
            }

            return false;
        }

        //Método para buscar la traducción a editar
        public Traduccion Buscar(int codigo)
        {
            return listaTraducciones[codigo];
        }

        public Dictionary<int,Traduccion> ListaTrads
        {
            get { return listaTraducciones; }
            set { listaTraducciones = value; }
        }

        public ArrayList CargarListaTipos()
        {
            string linea;
            try
            {
                StreamReader fichero = File.OpenText(@"./../../files/types/types.txt");
                do
                {
                    linea = fichero.ReadLine();

                    if (linea != null)
                        listaTipos.Add(linea);

                } while (linea != null);
                fichero.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error al cargar los tipos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return listaTipos;
        }

        public ArrayList CargarListaIdiomas()
        {
            string linea;
            try
            {
                StreamReader fichero = File.OpenText(@"./../../files/languages/languages.txt");
                do
                {
                    linea = fichero.ReadLine();

                    if (linea != null)
                        listaIdiomas.Add(linea);

                } while (linea != null);
                fichero.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error al cargar los idiomas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaIdiomas;
        }

        public Traduccion SeleccionarIdiomaCrear(int indexIdioma, string original, string traducida,
            int indexTipo, int codigo)
        {
            Traduccion traduccion = null;
            string tipo;

            switch (indexTipo)
            {
                case 0:
                    tipo = "Ciencia";
                    break;
                case 1:
                    tipo = "Literatura";
                    break;
                case 2:
                    tipo = "Deporte";
                    break;
                default:
                    tipo = "";
                    break;
            }

            switch (indexIdioma)
            {
                case 0:
                    traduccion = new TraduccionIngles(codigo, original, traducida, "English", tipo);
                    break;
                default:
                    traduccion = null;
                    break;
            }

            return traduccion;
        }

        public void GuardarTraducciones()
        {
            StreamWriter ficheroEspanyol;
            StreamWriter ficheroIdioma;
            string rutaFicheros = "./../../files";

            try
            {
                foreach (KeyValuePair<int,Traduccion> lista in listaTraducciones)
                {
                    ficheroEspanyol = File.CreateText(rutaFicheros+"/Spanish"+"/"+lista.Value.Tipo+"/"+ lista.Key+"_"+lista.Value.Tipo.ToLower()+".txt");
                    ficheroIdioma = File.CreateText(SeleccionarRutaGuardar(rutaFicheros,lista.Value.Idioma,lista.Value.Tipo,lista.Key));

                    ficheroEspanyol.WriteLine(lista.Value.NomOriginal);
                    ficheroIdioma.WriteLine(lista.Value.NomTraducida);

                    ficheroEspanyol.Close();
                    ficheroIdioma.Close();
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error al guardar las traducciones","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            string SeleccionarRutaGuardar(string rutaGeneral, string idioma, string tipo, int codTrad)
            {
                string rutaActual = rutaGeneral;

                switch (idioma)
                {
                    case "English":
                        rutaActual += "/English";
                        break;
                    default:
                        break;
                }

                switch (tipo)
                {
                    case "Ciencia":
                        rutaActual += "/Ciencia/"+codTrad+"_"+"ciencia.txt";
                        break;
                    case "Literatura":
                        rutaActual += "/Literatura/"+codTrad+"_"+"literatura.txt";
                        break;
                    case "Deporte":
                        rutaActual += "/Deporte/"+codTrad+"_"+"deporte.txt";
                        break;
                    default:
                        break;
                }

                return rutaActual;
            }
        }

        public Dictionary<int,Traduccion> CargarTraducciones()
        {
            string[] idiomas = { "English" };
            string[] tipos = { "Ciencia", "Literatura", "Deporte" };
            string rutaFicheros = "./../../files";
            Traduccion trad;
            int codigo;
            string lineaEspanyol;
            string lineaIdioma;
            

            int GetIndexTipo(string tipo)
            {
                if (tipo == tipos[0])
                    return 0;

                if (tipo == tipos[1])
                    return 1;

                if (tipo == tipos[2])
                    return 2;

                return -1;
            }

            int GetIndexIdioma(string idioma)
            {
                if (idioma == idiomas[0])
                    return 0;

                return -1;
            }

            int GetCodigo(string ficheroActual)
            {
                return Convert.ToInt32(ficheroActual.Substring(0, ficheroActual.IndexOf("_")));
            }

            try
            {
                foreach (string idioma in idiomas)
                {
                    foreach (string tipo in tipos)
                    {
                        string dirEspanyol = rutaFicheros + "/Spanish" + "/" + tipo;
                        string dirIdioma = rutaFicheros + "/" + idioma + "/" + tipo;

                        DirectoryInfo dirFicherosEspanyol = new DirectoryInfo(dirEspanyol);
                        DirectoryInfo dirFicherosIdioma = new DirectoryInfo(dirIdioma);

                        //Obtener ficheros del directorio para sacar su nombre, 
                        //como el nombre es igual en directorio español que el del otro idioma elegí el español para obtenerlo
                        FileInfo[] fichDirEspanyol = dirFicherosEspanyol.GetFiles();
                        FileInfo[] fichDirIdioma = dirFicherosIdioma.GetFiles();

                        foreach (FileInfo fichEspanyol in fichDirEspanyol)
                        {
                            codigo = GetCodigo(fichEspanyol.Name);  //Obtener el código del nombre del fichero

                            string rutaEspanyola = rutaFicheros+"/Spanish"+"/"+tipo+"/"+codigo+"_"+tipo.ToLower()+".txt";
                            string rutaIdioma = rutaFicheros+"/"+idioma+"/"+tipo+"/"+codigo+"_"+tipo.ToLower()+".txt";

                            StreamReader ficheroEspanyol = File.OpenText(rutaEspanyola);
                            StreamReader ficheroIdioma = File.OpenText(rutaIdioma);

                            int indexTipo = GetIndexTipo(tipo);
                            int indexIdioma = GetIndexIdioma(idioma);

                            do
                            {
                                lineaEspanyol = ficheroEspanyol.ReadLine();
                                lineaIdioma = ficheroIdioma.ReadLine();

                                if (lineaEspanyol != null || lineaIdioma != null)
                                {
                                    trad = SeleccionarIdiomaCrear(indexIdioma, lineaEspanyol, lineaIdioma, indexTipo, codigo);
                                    listaTraducciones.Add(codigo, trad);
                                }
                            } while (lineaEspanyol != null || lineaIdioma != null);
                            
                            ficheroEspanyol.Close();
                            ficheroIdioma.Close();

                            //Elimina los archivos después de cargarlos en el diccionario para evitar fallos en funcionamiento
                            File.Delete(rutaEspanyola);
                            File.Delete(rutaIdioma);
                        }
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error al cargar los datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return listaTraducciones;
        }

        public string GetNomIdioma(int index)
        {
            string idioma;
            switch (index)
            {
                case 0:
                    idioma = "English";
                    break;
                default:
                    idioma = "";
                    break;
            }
            return idioma;
        }

        public string GetNomTipo(int index)
        {
            string tipo;
            switch (index)
            {
                case 0:
                    tipo = "Ciencia";
                    break;
                case 1:
                    tipo = "Literatura";
                    break;
                case 2:
                    tipo = "Deporte";
                    break;
                default:
                    tipo = "";
                    break;
            }
            return tipo;
        }

        public int GetIndexIdioma(string idioma)
        {
            switch (idioma)
            {
                case "English":
                    return 0;
                default:
                    break;
            }
            return -1;
        }

        public int GetIndexTipo(string tipo)
        {
            switch (tipo)
            {
                case "Ciencia":
                    return 0;
                case "Literatura":
                    return 1;
                case "Deporte":
                    return 2;
                default:
                    break;
            }

            return -1;
        }

        public void FiltrarPorIdiomaTipo(ComboBox dropDownIdioma, ComboBox dropDownTipo, ListView lista)
        {
            int indexIdioma = dropDownIdioma.SelectedIndex;
            string idioma = GetNomIdioma(indexIdioma);
            int indexTipo = dropDownTipo.SelectedIndex;
            string tipo = GetNomTipo(indexTipo);

            if (lista != null)
            {
                if (indexIdioma != -1 || indexTipo != -1)
                {
                    lista.Items.Clear();
                    foreach (KeyValuePair<int, Traduccion> list in listaTraducciones)
                    {
                        if (idioma == list.Value.Idioma && tipo == list.Value.Tipo)
                        {
                            ListViewItem columna = new ListViewItem(list.Key.ToString());
                            columna.SubItems.Add(list.Value.NomOriginal);
                            columna.SubItems.Add(list.Value.NomTraducida);
                            lista.Items.Add(columna);
                        }
                    }
                }
            }
        }

        public void FiltrarPorNombre(KeyValuePair<int,Traduccion> list, TextBox nombreOriginalTraduccion, ListView listView)
        {
            if (list.Value.NomOriginal.ToLower().StartsWith(nombreOriginalTraduccion.Text.ToLower()))
            {
                ListViewItem columna = new ListViewItem(list.Key.ToString());
                columna.SubItems.Add(list.Value.NomOriginal);
                columna.SubItems.Add(list.Value.NomTraducida);
                listView.Items.Add(columna);
            }
        }

        public void ResetearControlesFormulario(ComboBox dropDownIdioma, ComboBox dropDownTipo, TextBox inputOriginal, TextBox inputTraducida)
        {
            dropDownIdioma.SelectedIndex = 0;
            dropDownTipo.SelectedIndex = 0;

            if (inputOriginal != null)
                inputOriginal.Clear();

            if (inputTraducida != null)
                inputTraducida.Clear();
        }
    }
}