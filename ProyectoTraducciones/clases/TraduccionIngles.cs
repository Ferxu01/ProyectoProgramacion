﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTraducciones.clases
{
    public class TraduccionIngles : Traduccion
    {
        public TraduccionIngles(int codigo, string original, string traducida, string idioma, string tipo) 
            :base(codigo, original, traducida, idioma, tipo)
        {
            rutaActual+="/English";
        }
    }
}
