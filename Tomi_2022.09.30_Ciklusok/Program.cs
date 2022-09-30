using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomi_2022._09._30_Ciklusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciklusok

            //1.Számlálós ciklus
            //Honnan indulunk;Meddig megyünk;Lépésköz
            for (int i = 1;i<=10;i += 2 /*i = i + 2*/)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (int i = 11; i <= 20; i = i + 1)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            
            //2.Előltesztelős ciklus
            int j = 1;
            while (j < 11)
            {
                Console.Write(j + " ");
                j++; //j = j + 1
            }

            //3.Hatultesztelős ciklus
            //j = 50;

            Console.WriteLine();

            int k = 50;
            do
            {
                //k = 60;
                Console.Write(k + " ");               
                k += 4;
            } while (k <= 80);

            Console.WriteLine();

            //4.-foreach
            int[] tomb = {1,2000,20,110,40,99,28};
            foreach (int i in tomb)
            {
                if (i>40)
                {
                    Console.Write(i + " ");
                }
            }

            //Példa
            //Kérje be a felhasználótól a hatvány alapját és kitevőjét, és írd ki
            //az értékét!
            Console.Write("Adja meg a hatvány alapját: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a hatvány kitevőjét: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow(x,y));

            Console.ReadKey();
        }
    }
}
