using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nutriologa_Global;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace Nutriologa_Datos
{
    public class Tratamiento_Datos
    {
        public List<Tratamiento> ObtenerTratamiento()
        {
            try
            {
                String Conexion = ConfigurationManager.AppSettings.Get("strConnection");
                List<Tratamiento> Lista = new List<Tratamiento>();
                Tratamiento Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, CommandType.StoredProcedure, "dbo.sp_MostrarTratamiento");
                while (Dr.Read())
                {
                    Item = new Tratamiento();
                    Item.IDTratamiento = !Dr.IsDBNull(Dr.GetOrdinal("IDTratamiento")) ? Dr.GetInt32(Dr.GetOrdinal("IDTratamiento")) : 0;
                    Item.Nombre = !Dr.IsDBNull(Dr.GetOrdinal("Nombre")) ? Dr.GetString(Dr.GetOrdinal("Nombre")) : string.Empty;
                    Item.Descripcion = !Dr.IsDBNull(Dr.GetOrdinal("Descripcion")) ? Dr.GetString(Dr.GetOrdinal("Descripcion")) : string.Empty;
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

        public Tratamiento ModificarTratamiento(Tratamiento tratamiento)
        {

            try
            {
                Tratamiento Item = new Tratamiento();
                SqlDataReader Dr = SqlHelper.ExecuteReader(ConfigurationManager.AppSettings.Get("strConnection"), CommandType.StoredProcedure, "dbo.sp_ModificarTratamiento", new SqlParameter("@IDTratamiento", tratamiento.IDTratamiento));

                while (Dr.Read())
                {
                    Item.Nombre = !Dr.IsDBNull(Dr.GetOrdinal("Nombre")) ? Dr.GetString(Dr.GetOrdinal("Nombre")) : string.Empty;
                    Item.Descripcion = !Dr.IsDBNull(Dr.GetOrdinal("Descripcion")) ? Dr.GetString(Dr.GetOrdinal("Descripcion")) : string.Empty;
                }
                Dr.Close();
                return Item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarPaciente(Tratamiento t)
        {
            try
            {

                object[] Parametros = { t.IDTratamiento };
                object Result = SqlHelper.ExecuteScalar(ConfigurationManager.AppSettings.Get("strConnection"), "dbo.sp_EliminarTratamiento", Parametros);
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarTratamientoModificado(Tratamiento t)
        {
            object[] Parametros = { t.IDTratamiento, t.Nombre, t.Descripcion };
            object Result = SqlHelper.ExecuteScalar(ConfigurationManager.AppSettings.Get("strConnection"), "dbo.sp_GuardarTratamientoModificado", Parametros);

        }

        public void GuardarTratamiento(Tratamiento t)
        {
            try
            {
                Comun.Conexion = ConfigurationManager.AppSettings.Get("strConnection");
                object[] Parametros = { t.Nombre, t.Descripcion };
                object Result = SqlHelper.ExecuteScalar(Comun.Conexion, "dbo.sp_CrearTratamiento", Parametros);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
