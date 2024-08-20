using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem01_Balboa
{
    public class Coordenadas
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public double PuntoA { get; set; }

        public double PuntoB { get; set; }

        public double PuntoC { get; set; }

        public double PuntoD { get; set; }


        public int CalcularArea() //Obtener el Area
        {
            return Base * Altura;
        }

        public int CalcularPerimetro() //Obtener el perimetro
        {
            return 2 * (Base + Altura);
        }



    }
}
