﻿using System;
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
        public void CrearCita(Cita cita, ref int verificar)
        {
            try
            {
                Comun.Conexion = ConfigurationManager.AppSettings.Get("strConnection");
                object[] Parametros = { cita.IDNombre, cita.IDHorario, cita.Fecha };
                object Result = SqlHelper.ExecuteScalar(Comun.Conexion, "dbo.sp_CrearCita", Parametros);
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

        public List<Cita> ObtenerPaciente(string Conexion)
        {
            try
            {
                Conexion = ConfigurationManager.AppSettings.Get("strConnection");
                List<Cita> Lista = new List<Cita>();
                Cita Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, CommandType.StoredProcedure, "dbo.sp_ComboPaciente");
                while (Dr.Read())
                {
                    Item = new Cita();
                    Item.IDNombre = !Dr.IsDBNull(Dr.GetOrdinal("IDNombre")) ? Dr.GetInt32(Dr.GetOrdinal("IDNombre")) : 0;
                    Item.Nombre = !Dr.IsDBNull(Dr.GetOrdinal("Nombre")) ? Dr.GetString(Dr.GetOrdinal("Nombre")) : string.Empty;
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

        public List<Cita> ObtenerHorario(string Conexion)
        {
            try
            {
                Conexion = ConfigurationManager.AppSettings.Get("strConnection");
                List<Cita> Lista = new List<Cita>();
                Cita Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, CommandType.StoredProcedure, "dbo.sp_ComboHorario");
                while (Dr.Read())
                {
                    Item = new Cita();
                    Item.IDHorario = !Dr.IsDBNull(Dr.GetOrdinal("IDHorario")) ? Dr.GetInt32(Dr.GetOrdinal("IDHorario")) : 0;
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

        public void EliminarPaciente(Cita c)
        {
            try
            {

                object[] Parametros = { c.IDCita };
                object Result = SqlHelper.ExecuteScalar(ConfigurationManager.AppSettings.Get("strConnection"), "dbo.sp_EliminarCita", Parametros);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cita> ObtenerCitasBusqueda(string Conexion, Cita cita)
        {
            try
            {
                Conexion = ConfigurationManager.AppSettings.Get("strConnection");
                List<Cita> Lista = new List<Cita>();
                Cita Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, CommandType.StoredProcedure, "dbo.sp_MostrarCitasBusqueda",new SqlParameter("@Nombre",cita.Nombre ), new SqlParameter("@Apellido", cita.Apellido));
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
        public List<Cita> ReporteCitasPeriodo(Cita cita)
        {
            try
            {
                string Conexion = ConfigurationManager.AppSettings.Get("strConnection");
                List<Cita> Lista = new List<Cita>();
                Cita Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, CommandType.StoredProcedure, "dbo.sp_ReportesCitasperiodo", new SqlParameter("@Fechain", cita.Fechain), new SqlParameter("@Fechafi", cita.Fechafi));
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

