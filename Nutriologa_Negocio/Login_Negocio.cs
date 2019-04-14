using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nutriologa_Global;
using Nutriologa_Datos;

namespace Nutriologa_Negocio
{
    public class Login_Negocio
    {
        public void ingresar(LoginNutriologa lg, ref int verificar)
        {
            Login_Datos ld = new Login_Datos();
                ld.ingresar(lg, ref verificar);
        }
    }
}
