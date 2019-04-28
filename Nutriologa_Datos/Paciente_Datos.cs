using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nutriologa_Global;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;

namespace Nutriologa_Datos
{
     public class Paciente_Datos
    {
        public void EliminarPaciente(Paciente p, ref int verificar)
        {
            try
            {

                object[] Parametros = {p.IDPaciente};
                object Result = SqlHelper.ExecuteScalar(ConfigurationManager.AppSettings.Get("strConnection"), "dbo.sp_EliminarPaciente", Parametros);
                if (Result != null)
                {
                    int.TryParse(Result.ToString(), out verificar);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void IngresarPaciente(Paciente p, ref int verificar)
        {
            try
            {

                object[] Parametros = { p.Nombre, p.Apellido, p.Telefono, p.NivColesterol, p.Promgrasa, p.Estatura, p.Edad, p.Talla, p.Peso, p.Nivtrigliceridos, p.Nivacidourico};
                object Result = SqlHelper.ExecuteScalar(ConfigurationManager.AppSettings.Get("strConnection"), "dbo.sp_IngresarPaciente", Parametros);
                if (Result != null)
                {
                    int.TryParse(Result.ToString(), out verificar);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
