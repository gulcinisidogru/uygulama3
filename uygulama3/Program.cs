using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama3
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int sayi, sayi1;
            Console.WriteLine("sayi girin");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayi girin");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            if (sayi % sayi1 == 0)
            {

                Console.WriteLine("sayi tam bolunur");
            }
            else
            {

                Console.WriteLine("sayi tam bolunmez");
            }
            Console.ReadKey();
        }
    }
}
