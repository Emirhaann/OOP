using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>(); // Tip Gücenli Liste
            sayilar.Add(1); // verebilirsin

            List<object> cuval = new List<object>(); // Tip Güvensiz
            cuval.Add(1);
            cuval.Add("sdkfhsşdf"); // verilebilir yani herşey belli değil
        }
    }
}
