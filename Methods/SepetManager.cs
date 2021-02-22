using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi! : " + urun.Adi);
        }

        public void Ekle2 (string urunAdi, string aciklama, double Fiyat) //Yanlış Kullanım, Yeni Bir Özellikte Tüm Fonksiyonlar Bozulur
        {
            Console.WriteLine("Sepete Eklendi! : " + urunAdi);
        }
    }
}
