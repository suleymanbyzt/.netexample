using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Süleyman", "Mahmut", "Özgün", "Murat" };

            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);

            //}

            List<string> listem = new List<string>
            {
                "Süleyman",
                "Kemal"
            };
            foreach (string a in listem)
            {
                Console.WriteLine(a);
            }
        }
    }
}