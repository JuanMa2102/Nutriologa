using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutriologa_Global
{
    public class Paciente
    {
        public int IDPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public decimal NivColesterol { get; set; }
        public decimal PromGrasa { get; set; }
        public decimal Estatura { get; set; }
        public int Edad { get; set; }
        public decimal Talla { get; set; }
        public decimal Peso { get; set; }
        public decimal NivTrigliceridos { get; set; }
        public decimal NivAcidoUrico { get; set; }

        public string Tratamiento { get; set; }
    }
}
