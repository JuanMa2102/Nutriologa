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
    public class Cita_Negocio
    {
        public string Conexion { get; set; }
        public string UserID { get; set; }
        public BindingList<Cita> ListaCita { get; set; }

        public Cita_Negocio(string _Conexion)
        {
            Conexion = _Conexion;
            ListaCita = new BindingList<Cita>(new List<Cita>());
            LlenarListaCita();
        }

        public void LlenarListaCita()
        {
            try
            {
                Cita_Datos RegionDatos = new Cita_Datos();
                List<Cita> ListaAux = RegionDatos.ObtenerCitas(Conexion);
                foreach (var Item in ListaAux)
                {
                    ListaCita.Add(Item);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
