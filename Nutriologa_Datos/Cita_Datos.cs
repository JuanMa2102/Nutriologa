using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nutriologa_Global;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Configuration;

namespace Nutriologa_Datos
{
    public class Cita_Datos
    {
        public List<Cita> ObtenerCitas(string Conexion)
        {
            try
            {
                Conexion = ConfigurationManager.AppSettings.Get("strConnection");
                List<Cita> Lista = new List<Cita>();
                Cita Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, CommandType.StoredProcedure, "dbo.sp_MostrarCitas");
                while (Dr.Read())
                {
                    Item = new Cita();
                    Item.IDCita = !Dr.IsDBNull(Dr.GetOrdinal("IDCita")) ? Dr.GetInt32(Dr.GetOrdinal("IDCita")) : 0;
                    Item.Nombre = !Dr.IsDBNull(Dr.GetOrdinal("Nombre")) ? Dr.GetString(Dr.GetOrdinal("Nombre")) : string.Empty;
                    Item.Fecha = !Dr.IsDBNull(Dr.GetOrdinal("Fecha")) ? Dr.GetDateTime(Dr.GetOrdinal("Fecha")) : DateTime.MinValue;
                    Item.Horario = !Dr.IsDBNull(Dr.GetOrdinal("Horario")) ? Dr.GetString(Dr.GetOrdinal("Horario")) : string.Empty;
                    Lista.Add(Item);
                }
                Dr.Close();
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
