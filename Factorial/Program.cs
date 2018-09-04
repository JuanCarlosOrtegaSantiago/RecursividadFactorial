using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int valor;
                Console.WriteLine("Ingresa el numero:");
                valor = int.Parse(Console.ReadLine());
                Recursivo r = new Recursivo();
                Console.WriteLine("El factorial de {0} es: {1}",valor,r.Fac(valor));
                Console.Read();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error en: {0}",ex);
            }
            

        }
    }
}
