using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTraducciones.clases
{
    public class ListaTraducciones
    {
        Dictionary<int,Traduccion> listaTraducciones;
        Dictionary<int,string> listaCodigosTipo;

        public ListaTraducciones()
        {
            listaTraducciones = new Dictionary<int,Traduccion>();
            listaCodigosTipo = new Dictionary<int,string>();
        }

        public void Add(Traduccion traduccion)
        {

        }

        public void Borrar(int codigo)
        {

        }

        public void Editar(Traduccion traduccion)
        {

        }

        public void Buscar(int codigo)
        {

        }
    }
}
