using System;

namespace Poliformizim2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cember cember= new cember();
            cember.YariCap = 3;
            Console.WriteLine("Cember Alani:" + cember.Alan());

            Dikdortgen dikdortgen= new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 5;

            Console.WriteLine("Diktorgen Alan:" + dikdortgen.Alan());

          

        }
    }
}
