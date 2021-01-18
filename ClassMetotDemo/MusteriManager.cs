using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " +musteri.Adi);

        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.Adi);

        }

        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri güncellendi: " + musteri.Adi);

        }

        public void Bilgileri(int Id, string Adi, int Yasi, double HarcamaLimiti)
        {
            Console.WriteLine("Müşteri bilgiler şunlardır : " + "İd = " + Id + " İsim =  " + Adi + 
                " Yaş =  " + Yasi + " Harcama Limiti =  " + HarcamaLimiti);

        }


    }
}
