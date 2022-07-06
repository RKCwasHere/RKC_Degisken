using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro_
{
    internal class Program
    {
        static void Main(string[] args)
           
        {
            Kurs kurs1 = new Kurs();            //Class değişkeni oluşturulur.
            kurs1.kursAdi = "C++";
            kurs1.kursEgitmeni = "Riza KACAN";
            kurs1.izlenmeOrani = 69;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "C#";
            kurs2.kursEgitmeni = "Engin Demirog";
            kurs2.izlenmeOrani = 85;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Java";
            kurs3.kursEgitmeni = "Kerem Varıs";
            kurs3.izlenmeOrani = 100;



            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};  // array yani dizi oluşturulur. tüm dataları kurslar dizinde topladık.

            foreach (var kurs in kurslar)       //foreach komutu ile bir döngü sağlanır.
            {
                Console.WriteLine(kurs.kursAdi + ":" + kurs.kursEgitmeni + ":" + kurs.izlenmeOrani);
            }

           // Console.WriteLine(kurs1.kursAdi + ":" + kurs1.kursEgitmeni + ":" + kurs1.izlenmeOrani);
            

            Console.ReadLine();

        }
    }
    class Kurs         //class tab+tab diyerek oluşturulur.
    {
        public string kursAdi { get; set; }       // yazı textlerinde string kullanılır.

        public string kursEgitmeni { get; set; }

        public int izlenmeOrani { get; set; }     //tam sayılarda int kullanılır. /  Bellekte 2 Byte veya 16 bit yer kaplar.
    }
}
