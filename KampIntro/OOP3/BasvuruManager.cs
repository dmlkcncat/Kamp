using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediManager krediManager, ILogerService logerService)
        {
            krediManager.Hesapla();
            logerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var item in krediler)
            {
                item.Hesapla();
            }
        }
    }
}
