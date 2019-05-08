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
        public void GuardarPaciente(Paciente p, ref int verificar)
        {
            try
            {

                object[] Parametros = { p.Nombre, p.Apellido, p.Telefono, p.NivColesterol, p.PromGrasa, p.Estatura, p.Edad, p.Talla, p.Peso, p.NivTrigliceridos, p.NivAcidoUrico};
                object Result = SqlHelper.ExecuteScalar(ConfigurationManager.AppSettings.Get("strConnection"), "dbo.sp_GuardarPaciente", Parametros);
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

        public Paciente ModificarPaciente(Paciente paciente)
        {
            try
            {
                Paciente Item = new Paciente();
                SqlDataReader Dr = SqlHelper.ExecuteReader(ConfigurationManager.AppSettings.Get("strConnection"), CommandType.StoredProcedure, "dbo.sp_ModificarPaciente", new SqlParameter("@IDPaciente",paciente.IDPaciente));

                while (Dr.Read())
                {
                    
                    Item.Nombre = !Dr.IsDBNull(Dr.GetOrdinal("Nombre")) ? Dr.GetString(Dr.GetOrdinal("Nombre")) : string.Empty;
                    Item.Apellido = !Dr.IsDBNull(Dr.GetOrdinal("Apellido")) ? Dr.GetString(Dr.GetOrdinal("Apellido")) : string.Empty;
                    Item.Telefono = !Dr.IsDBNull(Dr.GetOrdinal("Telefono")) ? Dr.GetString(Dr.GetOrdinal("Telefono")) : string.Empty;
                    Item.NivColesterol = !Dr.IsDBNull(Dr.GetOrdinal("NivColesterol")) ? Dr.GetDecimal(Dr.GetOrdinal("NivColesterol")) : 0;
                    Item.PromGrasa = !Dr.IsDBNull(Dr.GetOrdinal("PromGrasa")) ? Dr.GetDecimal(Dr.GetOrdinal("PromGrasa")) : 0;
                    Item.Estatura = !Dr.IsDBNull(Dr.GetOrdinal("Estatura")) ? Dr.GetDecimal(Dr.GetOrdinal("Estatura")) : 0;
                    Item.Edad = !Dr.IsDBNull(Dr.GetOrdinal("Edad")) ? Dr.GetInt32(Dr.GetOrdinal("Edad")) : 0;
                    Item.Talla = !Dr.IsDBNull(Dr.GetOrdinal("Talla")) ? Dr.GetDecimal(Dr.GetOrdinal("Talla")) : 0;
                    Item.Peso = !Dr.IsDBNull(Dr.GetOrdinal("Peso")) ? Dr.GetDecimal(Dr.GetOrdinal("Peso")) : 0;
                    Item.NivTrigliceridos = !Dr.IsDBNull(Dr.GetOrdinal("NivTrigliceridos")) ? Dr.GetDecimal(Dr.GetOrdinal("NivTrigliceridos")) : 0;
                    Item.NivAcidoUrico = !Dr.IsDBNull(Dr.GetOrdinal("NivAcidoUrico")) ? Dr.GetDecimal(Dr.GetOrdinal("NivAcidourico")) : 0;
                }
                Dr.Close();
                return Item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LiberarPaciente(Paciente p)
        {
            try
            {
                object[] Parametros = { p.IDPaciente };
                object Result = SqlHelper.ExecuteScalar(ConfigurationManager.AppSettings.Get("strConnection"), "dbo.sp_LiberarPaciente", Parametros);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void GuardarPacienteModificado(Paciente p)
        {
            try
            {
                object[] Parametros = { p.IDPaciente, p.Nombre, p.Apellido, p.Telefono, p.NivColesterol, p.PromGrasa, p.Estatura, p.Edad, p.Talla, p.Peso, p.NivTrigliceridos, p.NivAcidoUrico };
                object Result = SqlHelper.ExecuteScalar(ConfigurationManager.AppSettings.Get("strConnection"), "dbo.sp_GuardarPacienteModificado", Parametros);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
