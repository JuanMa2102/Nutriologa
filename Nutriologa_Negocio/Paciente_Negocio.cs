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
        public Paciente_Negocio(string _Conexion)
        {
            Conexion = _Conexion;
            ListaPaciente = new BindingList<Paciente>(new List<Paciente>());
            LlenarLista();
        }

        public void LlenarLista()
        {
            try
            {
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
    }
}
