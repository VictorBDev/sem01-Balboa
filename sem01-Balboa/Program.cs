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

            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Base = 10;
            rectangulo.Altura = 20;

            area = rectangulo.CalcularArea();
            perimetro = rectangulo.CalcularPerimetro();

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
                CodigoEstudiante = "114306"
            };

        }
    }
}
