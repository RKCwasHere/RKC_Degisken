using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştimre Kampı";
            string kurs2 = "Programlamaya başlangıc için temel Kurs";
            string kurs3 = "Java";



            //array - dizi []

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştimre Kampı",
                "Programlamaya başlangıc için temel Kurs","Java"}; //array - dizi []




            // döngüler for - foreach 

            for (int i = 0; i < 3; i++)  
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("sayfa sonu - footer");

            Console.ReadLine();

        }
    }
}
