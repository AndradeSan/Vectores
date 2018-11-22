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

            Console.WriteLine("{0} Elevado a {1} = {2}",3,4,ExponenteFor(3,4));
            try
            {
                Console.WriteLine("-5 Elevado a la 2 {0}", ExponenteFor(-5, 2));
            }catch(Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message.ToString());

            }
            Console.WriteLine("2 Elevado a la 5 {0}", ExponenteFor(2,5));
            Console.WriteLine("la tota 5 equivale a{0}",Calificacion(5));
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
        public static String Calificacion(double c)
        {
            int x = 2;
            if (c > 0 && c < 5)
                return "Suspenso";
            else
                 if (c > 4 && c < 6.6)
                return "aprovado";
            else
                 if (c > 6.4 && c < 8.6)
                return "Notable";
            else
                 if (c > 8.4 && c < 10)
                return "sobresaliente";
            else
                 if (c == 10)
                return "Matricula de Honor";
            else
                return "Fuera de Rango";

        }


    }
}
