using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nutriologa_Global;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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

        public List<Paciente> ObtenerPaciente(string Conexion)
        {
            try
            {
                Conexion = ConfigurationManager.AppSettings.Get("strConnection");
                List<Paciente> Lista = new List<Paciente>();
                Paciente Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, CommandType.StoredProcedure, "dbo.sp_MostrarPaciente");
                while (Dr.Read())
                {
                    Item = new Paciente();
                    Item.IDPaciente = !Dr.IsDBNull(Dr.GetOrdinal("IDPaciente")) ? Dr.GetInt32(Dr.GetOrdinal("IDPaciente")) : 0;
                    Item.Nombre = !Dr.IsDBNull(Dr.GetOrdinal("Nombre")) ? Dr.GetString(Dr.GetOrdinal("Nombre")) : string.Empty;
                    Item.Apellido = !Dr.IsDBNull(Dr.GetOrdinal("Apellido")) ? Dr.GetString(Dr.GetOrdinal("Apellido")) : string.Empty;
                    Item.Telefono = !Dr.IsDBNull(Dr.GetOrdinal("Telefono")) ? Dr.GetString(Dr.GetOrdinal("Telefono")) : string.Empty;
                    Item.Edad = !Dr.IsDBNull(Dr.GetOrdinal("Edad")) ? Dr.GetInt32(Dr.GetOrdinal("Edad")) : 0;
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
