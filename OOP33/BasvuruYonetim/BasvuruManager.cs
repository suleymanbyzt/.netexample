using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP33.BasvuruYonetim
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var item in krediler)
            {
                item.Hesapla();
            }
        }

        public void SistemBilgilendirmesiYap(List<ILoggerService> loggerServices)
        {
            foreach (var duyuru in loggerServices)
            {
                duyuru.Log();
            }
        }
    }
}
