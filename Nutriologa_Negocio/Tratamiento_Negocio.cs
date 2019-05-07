using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nutriologa_Global;
using Nutriologa_Datos;
using System.ComponentModel;

namespace Nutriologa_Negocio
{
    public class Tratamiento_Negocio
    {
        public BindingList<Tratamiento> ListaTratamiento { get; set; }
        public BindingList<Tratamiento> ListaReporteTratamiento { get; set; }
        public string Conexion;
        public Tratamiento_Negocio(string _Conexion)
        {
        
            Conexion = _Conexion;
            ListaTratamiento = new BindingList<Tratamiento>(new List<Tratamiento>());
            ListaReporteTratamiento = new BindingList<Tratamiento>(new List<Tratamiento>());
            LlenarListaTratamiento();
            LlenarReportePacientesActivos();
        }

        public void LlenarListaTratamiento()
        {
            try
            {
                ListaTratamiento.Clear();
                Tratamiento_Datos RegionDatos = new Tratamiento_Datos();
                List<Tratamiento> ListaAux = RegionDatos.ObtenerTratamiento();
                foreach (var Item in ListaAux)
                {
                    ListaTratamiento.Add(Item);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Tratamiento ModificarTratamiento(Tratamiento tratamiento)
        {
            Tratamiento_Datos regiondatos = new Tratamiento_Datos();
            return regiondatos.ModificarTratamiento(tratamiento);
        }

        public void GuardarTratamiento(Tratamiento t)
        {
            Tratamiento_Datos regionDatos = new Tratamiento_Datos();
            regionDatos.GuardarTratamiento(t);
        }

        public void GuardarTratamientoModificado(Tratamiento t)
        {
            Tratamiento_Datos regionDatos = new Tratamiento_Datos();
            regionDatos.GuardarTratamientoModificado(t);
        }

        public void EliminarTratamiento(Tratamiento t)
        {
            Tratamiento_Datos regionDatos = new Tratamiento_Datos();
            regionDatos.EliminarPaciente(t);
        } 
            public void LlenarReportePacientesActivos()
        {
            try
            {
                ListaReporteTratamiento.Clear();
                Tratamiento_Datos RegionDatos = new Tratamiento_Datos();
                List<Tratamiento> ListaAux = RegionDatos.ReportePacientesActivos();
                foreach (var Item in ListaAux)
                {
                    ListaReporteTratamiento.Add(Item);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
