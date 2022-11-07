using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FP_01._11_TODO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            S1();
            S2();
            S3();
            S4();
           
        }
        private static void S1()
        {
            Console.WriteLine("Introduceti valoarea n");
            int n;
            Console.ForegroundColor = ConsoleColor.Green;
            n=int.Parse(Console.ReadLine());
            for(int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= n - i + 1; j++) Console.Write('*');
                for(int j=1; j <= 2*(i-1); j++) Console.Write(' ');
                for(int j=1;j<=n - i + 1; j++) Console.Write('*');
                Console.WriteLine();
            }
            Console.ReadKey();

        }
        private static void S2()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Introduceti valoarea n");
            int n;
            Console.ForegroundColor= ConsoleColor.Green;
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                for(int j=1;j<= n-i+1; j++) Console.Write('*');
                for (int j = 1; j <= 2 * (i - 1); j++) Console.Write(' ');
                for(int j=1;j<=n-i+1; j++) Console.Write('*');
                Console.WriteLine();
            }
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= n - i + 1; j++) Console.Write('*');
                for (int j = 1; j <= 2 * (i - 1); j++) Console.Write(' ');
                for (int j = 1; j <= n - i + 1; j++) Console.Write('*');
                Console.WriteLine();
            }
            Console.ReadKey();

        }
        private static void S3()
        {   Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("Introduceti numarul n");
            int n=int.Parse(Console.ReadLine());
            int aux, max = n % 10,o=0,nr = 1,p,aux2;
            aux = n;
            while (aux > 0) { nr++;
                aux = aux / 10;
            }
            for(int i = 1; i <= nr; i++)
            {
                p = Convert.ToInt32(Math.Pow(10,i));
                aux = n % p;
                aux2 = aux;
                o = 0;
                while (aux > 0) { o = (o * 10) + (aux % 10);
                    aux = aux / 10;
                }
                if (o == aux2) { if (o > max) max = o; }

            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
        private static void S4()
        {Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("Introduceti cele 2 date,una sub cealalta, cele 2 date se vor scrie sub forma ll.zz.aaaa");
            DateTime d1 = Convert.ToDateTime(Console.ReadLine());
            DateTime d2 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Numarul de zile dintre cele 2 date este ");
            Console.WriteLine((d2-d1).TotalDays);

        }
    }
}
