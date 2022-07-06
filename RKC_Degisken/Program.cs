using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKC_Degisken
{
    internal class Program
    {
        static void Main(string[] args)

          
        {

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("i");
            }
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.69;
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOrani);
            Console.WriteLine(kategoriEtiketi);
            bool sistemeGirisYapmisMi = true;             

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("artısButonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("azalısButonu");
            }

            else
            {
                Console.WriteLine("degismediButonu");
            }

            if (sistemeGirisYapmisMi == false)

            {
                Console.WriteLine("kullaniciAyarlarıButonu");
              
            }
            else
            {
                Console.WriteLine("girisYapButonu");
            }
            
         
            
         


            Console.ReadLine();

            


        }
    }
}
