using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sueldo;
            string lista;
            Console.Write("Ingrese su sueldo: ");
            lista = Console.ReadLine();
            sueldo= float.Parse(lista);
            if (sueldo > 3000) 
            {
                Console.Write("Esta persona paga impuestos");
            }
            else { Console.Write("Esta persona no paga impuestos"); }
            Console.ReadKey();
        }
    }
}
