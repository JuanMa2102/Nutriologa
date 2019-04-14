using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutriologa_Global
{
    public static class Comun
    {
        private static string _Conexion;

        public static string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
    }
}
