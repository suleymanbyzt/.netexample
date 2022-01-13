using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP33
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BirSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("%16 Faiz oranı ileİhtiyaç Kredisi ödeme planı hesaplandı");
        }
    }
}
