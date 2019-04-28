using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nutriologa_Global;
using Nutriologa_Datos;

namespace Nutriologa_Negocio
{
   public class Cita_Negocio
    {
        public void CrearCita(Cita c, ref int verificar)
        {
            Cita_Datos cd = new Cita_Datos();
            cd.CrearCita(c, ref verificar);
        }
    }
}
