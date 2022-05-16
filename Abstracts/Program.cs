using Abstracts.Mobilyalar;
using System;

namespace Abstracts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gitar yamaha = new Gitar();
            bateri bateri = new bateri();
            Piano piano = new Piano();

            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "Ali";
            muzisyen.Soyadi = "yilmaz";

            //Musiyenin caldıgı enstruman MuzikAleti abstract tipinden olduğundan
            //ve Gitar, Piano, Bateri sınıflarında Muzikaleti sınıfını temel aldığından dolayı 
            //istediğimiz bir muzik aletini bu property'e atayabiliyoruz.
            muzisyen.CaldigiEnstruman = yamaha;
            muzisyen.CaldigiEnstruman = bateri;
            muzisyen.CaldigiEnstruman = piano;

            //asagıdaki GenelYetenek alanı object turunden olduğundan
            //istediğimiz değeri atayabiliyoruz
            muzisyen.GenelYetenek = new Araba();
            muzisyen.GenelYetenek = DateTime.Now;
            muzisyen.GenelYetenek = "Guzel Yetenekleri Var";
            muzisyen.GenelYetenek = 12.8f;










            Kanepe İstikbal = new Kanepe();
            İstikbal.Bazalimi = true;
            İstikbal.Renk = "Beyaz";
            İstikbal.Kumasturu = " Tay tuyu";

            İstikbal.OzellikleriYaz();
        }

        public class Araba
        {

        }
    }
}
