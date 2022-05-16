using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    internal class BasePhone
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Fiyat { get; set; }

        //Virtual değiştirilebilir anlamına geliyor
        public virtual  void TelefonCal()
        {
          

            using (SoundPlayer player = new SoundPlayer("default.wav"))
            {
                player.Play();
            }
        }

        public string Test()
        {
            return "deneme 123";
        }

    }
}
