using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CapaDatos;
using CapaEntidad;


namespace CapaNegocios
{
    public class Negocio
    {
        Datos dts = new Datos();
        public double N_suma(Entidad obj)
        {
            return dts.D_suma(obj);
        
        }


    }
}
