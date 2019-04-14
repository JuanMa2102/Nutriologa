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
    public class Login_Datos
    {
        public void ingresar(LoginNutriologa ln, ref int verificar)
        {
            try
            {

                object[] Parametros = { ln.usuario, ln.pass};
                object Result = SqlHelper.ExecuteScalar(ConfigurationManager.AppSettings.Get("strConnection"), "dbo.sp_login", Parametros);
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
