using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICreditManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme

            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnIzleme(List<ICreditManager> credits)
        {
            foreach (var kredi in credits)
            {
                kredi.Hesapla();
            }
        }
    }
}
