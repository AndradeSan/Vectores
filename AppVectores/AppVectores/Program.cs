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
            Console.WriteLine("la Nota 5 equivale a{0}",Calificacion(5));

            vectorinicializar();
            vectortarea();

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
        public static void vectorinicializar()
        {

            int[] x = new int[8];
            x[0] = 10;
            x[1] = 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;
            //x[8] = 10;
            //x[9] = 10;
            int suma = 0,contador=0;
            double promedio;

            //imprimir vector
            Console.WriteLine("\nELEMENTOS DEL VECTOR \n====================\n");
            for (int i = 0; i < x.Length; i++)
            {
                suma = suma + x[i];
              
                //contador = contador+1;
                Console.WriteLine("Elemento Indice {0}--> {1}", (i + 1), x[i]); 
                
            }
            promedio = (double)suma / x.Length;
            Console.WriteLine("Total de la Suma de los elementos del Vector  {0}",suma);
            Console.WriteLine("Promedio del Vector  {0}", promedio);
            //Console.WriteLine("Promedio del Vector  {0}", contador);

        }
       public static void vectortarea()
        {
            int num,mayor=0,menor=900000000;
            int[] x = new int[10];

            for(int i = 0; i < 10; i++)
            {
                do
                {
                Console.WriteLine("\nIngrese el Numero");
                num = int.Parse(Console.ReadLine());
                    x[i] = num;

               } while (num < 0 || num > 1001);
            if(mayor<=x[i])
               {
                    mayor = x[i];

                };
                if (menor >= x[i])
                {
                    menor = x[i];
                };
          }

          Console.WriteLine("El Numero mayor es {0} ", mayor);
            Console.WriteLine("El Numero menor es {0} ", menor);

        }

    }
}
