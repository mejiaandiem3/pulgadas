using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pulgadas
{
    class Program
    {
        static void Main(string[] args)
        {

            double pulgada=2.54; //1 pulgada = 2.54 cm 
            double centimetrosconv;
            double solucion1;

            Console.WriteLine("Conversion de centimetros a pulgadas.");

            Console.WriteLine("Escribe los centimetros a convertir: ");
            centimetrosconv = Convert.ToDouble(Console.ReadLine());

            solucion1 = centimetrosconv * pulgada;

            Console.WriteLine("Este es el valor en pulgadas: "+ solucion1);



            Console.ReadKey();



        }
    }
}
