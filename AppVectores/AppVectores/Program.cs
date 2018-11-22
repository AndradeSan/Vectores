using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control de Versiones");
            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Hola Mundo GitHab");
            Console.WriteLine("Probando Control de Versiones");

            Console.WriteLine("Resultado Potencia: {0}",ExponenteFor(3,4));
            try
            {
                Console.WriteLine("-5 Elevado a la 2 {0}", ExponenteFor(-5, 2));
            }catch(Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message.ToString());

            }
            Console.WriteLine("2 Elevado a la 5 {0}", ExponenteFor(2,5));
            Console.ReadKey();
     
        }
        public static int ExponenteFor(int x, int y)
        {
            int acum = 1;
            if (x <= 0)
            {
                throw new Exception("X debe ser Positivo...");
            }
            if (y <= 0)
            {
                throw new Exception("Y debe ser Positivo...");
            }
            // if (x > 1 && y > 1)
            for (int i = 1; i <= y; i++)
                    acum *= x;
            return (acum);

        }


    }
}
