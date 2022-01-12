using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    class Program
    {

        static void Main(string[] args)
        {
            Kurslar yapi = new Kurslar();
            yapi.KursAdi = "C#";
            yapi.Egitmen = "Mehmet Bayrak";
            yapi.IzlenmeOrani = 95;

            Kurslar yapi2 = new Kurslar();
            yapi2.KursAdi = "Python";
            yapi2.Egitmen = "Başak Demir";
            yapi2.IzlenmeOrani = 78;

            Kurslar yapi3 = new Kurslar();
            yapi3.KursAdi = "JavaScript";
            yapi3.Egitmen = "Taylan Dağlar";
            yapi3.IzlenmeOrani = 78;

            Kurslar[] kurslarsa = new Kurslar[] { yapi, yapi2, yapi3 };


            foreach (var item in kurslarsa)
            {
                Console.WriteLine($"Kurs adı: {item.KursAdi} Kurs Eğitmen: {item.Egitmen} ");
            }
            Console.ReadKey();
        }
    }
    class Kurslar
    {
        public string KursAdi{ get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
