using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExprecionesRegulares
{
    public class AnalizadorLexico
    {
        public int EstadoFinal = 100
        public void validar (KeyPressEventArgs e)
        {
            int estado = 0;
            int c = inspeccionar();
            int cont = 0;
            int NuevoEstado = tabla(estado, c);
                while(NuevoEstado != EstadoFinal)
            {
                Avanza();
                c = inspeccionar();
                estado = NuevoEstado;
                NuevoEstado = tabla(estado, c);
                cont = cont + 1;
            }
            if (cont == 0)
                avanzar();
        }

    }
}
