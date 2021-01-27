using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            //ihtiyacCreditManager.Hesapla();

            CarCreditManager carCreditManager = new CarCreditManager();
            //carCreditManager.Hesapla();

            KonutCreditManager konutCreditManager = new KonutCreditManager();
            //konutCreditManager.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            basvuruManager.BasvuruYap(konutCreditManager,fileLoggerService);

            //basvuruManager.BasvuruYap(carCreditManager);

            //basvuruManager.BasvuruYap(ihtiyacCreditManager);

            List<ICreditManager> credits = new List<ICreditManager>() {ihtiyacCreditManager, carCreditManager, konutCreditManager };
            basvuruManager.KrediOnIzleme(credits);
        }
    }
}
