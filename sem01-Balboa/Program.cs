using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem01_Balboa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area = 0;
            int perimetro = 0;

            Coordenadas coordenadas = new Coordenadas();
            coordenadas.Base = 10;
            coordenadas.Altura = 20;

            area = coordenadas.CalcularArea();
            perimetro = coordenadas.CalcularPerimetro();

            Console.WriteLine("El area es: ");
            Console.WriteLine(area);

            Console.WriteLine("El perímetro es: ");
            Console.WriteLine(perimetro);

            Console.WriteLine("Hola Mundo");
            Console.Read();

            Persona persona = new Persona
            {
                Nombres = "Victor",
                Apellidos = "Balboa",
            };


            Profesor profesor = new Profesor
            {
                Nombres = "",
                Apellidos = "",
                Sueldo = 1200
            };

            Estudiante estudiante = new Estudiante
            {
                Nombres = "",
                Apellidos = "",
                CodigoEstudiante = "114326"
            };


            /*Coordenadas coordenadas = new Coordenadas();*/
            coordenadas.Base = 10;
            coordenadas.Altura = 20;
            coordenadas.PuntoA = 0.0;
            coordenadas.PuntoB = 0.8;
            coordenadas.PuntoC = 4.8;
            coordenadas.PuntoD = 4.0;




        }
    }
}
