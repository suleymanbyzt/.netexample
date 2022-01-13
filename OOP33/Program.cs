using System;

namespace OOP33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();      
            BasvuruYonetim.BasvuruManager basvuruManager = new BasvuruYonetim.BasvuruManager();
            
            //-------------------------------------------------

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService);

            List <IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKrediManager, 
                konutKrediManager,
                tasitKrediManager
            };

            ILoggerService smsLoggerService = new LogServices.SmsLoggerService();
            List<ILoggerService> loggerServices = new List<ILoggerService>()
            {
                fileLoggerService,
                smsLoggerService
            };

            basvuruManager.SistemBilgilendirmesiYap(loggerServices);
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}