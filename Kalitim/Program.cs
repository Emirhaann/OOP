using System;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kisi sınıfından bir örnek alalım

            Kisi ali = new Kisi();
            Personel ayse = new Personel();
            Personel fatma = new Personel("Fatma", "Kaya");
            Console.WriteLine("Asye Maas:" + ayse.Maas);
            SatisMuduru veli = new SatisMuduru();

            Console.WriteLine("Satis Muduru" + veli.Maas);
            
        }
    }
}
