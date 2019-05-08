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
   public class Paciente_Negocio
    {
        public string Conexion { get; set; }
        public BindingList<Paciente> ListaPaciente { get; set; }
        public BindingList<Tratamiento> ListaTratamiento { get; set; }

        public Paciente_Negocio(string _Conexion)
        {
            Conexion = _Conexion;
            ListaPaciente = new BindingList<Paciente>(new List<Paciente>());
            ListaTratamiento = new BindingList<Tratamiento>(new List<Tratamiento>());
            LlenarLista();
        }
        public Paciente ModificarPaciente(Paciente paciente)
        {
            Paciente_Datos regiondatos = new Paciente_Datos();
            return regiondatos.ModificarPaciente(paciente);
        }
        public void LlenarLista()
        {
            try
            {
                ListaPaciente.Clear();
                Paciente_Datos RegionDatos = new Paciente_Datos();
                List<Paciente> ListaAux = RegionDatos.ObtenerPaciente(Conexion);
                foreach (var Item in ListaAux)
                {
                    ListaPaciente.Add(Item);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarPaciente(Paciente p, ref int verificar)
        {
            Paciente_Datos pd = new Paciente_Datos();
            pd.EliminarPaciente(p, ref verificar);
        }

        public void LlenarListaTratamiento()
        {
            try
            {
                ListaTratamiento.Clear();
                Paciente_Datos RegionDatos = new Paciente_Datos();
                List<Tratamiento> ListaAux = RegionDatos.ObtenerTratamiento(Conexion);
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

        public void GuardarPaciente(Paciente p, ref int verificar)
        {
            Paciente_Datos pd = new Paciente_Datos();
            pd.GuardarPaciente(p, ref verificar);
        }
        public void GuardarPacienteModificado(Paciente p)
        {
            Paciente_Datos pd = new Paciente_Datos();
            pd.GuardarPacienteModificado(p);
        }
        public void LiberarPaciente(Paciente paciente)
        {
            Paciente_Datos regionDatos = new Paciente_Datos();
            regionDatos.LiberarPaciente(paciente);
        }
    }
}
