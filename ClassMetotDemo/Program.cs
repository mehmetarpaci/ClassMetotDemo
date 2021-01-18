using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 10;
            musteri1.Adi = "Ahmet Anayurt";
            musteri1.Yasi = 37;
            musteri1.HarcamaLimiti = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 11;
            musteri2.Adi = "Mügeban Kainat";
            musteri2.Yasi = 47;
            musteri2.HarcamaLimiti = 17;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 12;
            musteri3.Adi = "Bülent Çavuş";
            musteri3.Yasi = 53;
            musteri3.HarcamaLimiti = 198;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri ID: "+musteri.Id);
                Console.WriteLine("Müşteri İsmi:"+musteri.Adi);
                Console.WriteLine("Müşteri Yaşı:"+musteri.Yasi);
                Console.WriteLine("Müşteri Harcama Limiti:"+musteri.HarcamaLimiti);




            }

        }
    }
}
