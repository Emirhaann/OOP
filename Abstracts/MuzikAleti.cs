using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public abstract class MuzikAleti
    {

        //Abstract class'lar sadece base class olarak tasarlanmıştır. O yüzden sadece kalıtım verir.
        // Abstract klaslardan instance alınamaz.Yani new'lenemez.. 
        public string Marka { get; set; }
        public string Aciklama { get; set; }
        //Soyut Metoddur. Miras verdeiği yerde mutlaka tanımlanmalıdır!.
        //Yani gövdesi yazılmalıdır.
        //Gövde: Metodun içerisinde ki kodlar

        //Abstract olarak işaretlennmiş tüm yapılar override edilmek zorundadır.
        public abstract string Cal();
    }
}
