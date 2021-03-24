using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 kredi türü yerine IKrediManager yazarsakda aynı sonucu alırdık.

            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
            // ILoggerService databaseLoggerService = new DatabaseLoggerService();
            // ILoggerService fileLogerService = new FileLoggerService()

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}


            

            
