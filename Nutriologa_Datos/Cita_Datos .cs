using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using Nutriologa_Global;
using System.Configuration;
using System.Data.SqlClient;

namespace Nutriologa_Datos
{
    public class Cita_Datos
    {
        public void CrearCita(Cita c, ref int verificar)
        {
            try
            {

                object[] Parametros = {c.idcita,c.fecha,c.horario,c.idpaciente};
                object Result = SqlHelper.ExecuteScalar(ConfigurationManager.AppSettings.Get("strConnection"), "dbo.sp_crearCita", Parametros);
                if (Result != null)
                {
                    int.TryParse(Result.ToString(), out verificar);
                }
            }
            catch(Exception ex)
            {
                
            }
        }
    }
}
