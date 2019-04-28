using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nutriologa_Global;
using Nutriologa_Datos;

namespace Nutriologa_Negocio
{
   public class Paciente_Negocio
    {
        public void EliminarPaciente(Paciente p, ref int verificar)
        {
            Paciente_Datos pd = new Paciente_Datos();
            pd.EliminarPaciente(p, ref verificar);
        }
        public void IngresarPaciente(Paciente p, ref int verificar)
        {
            Paciente_Datos pd = new Paciente_Datos();
            pd.IngresarPaciente(p, ref verificar);
        }
    }
}
