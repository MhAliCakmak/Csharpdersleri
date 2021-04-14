using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace DERS4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i;
            List<string> isimler = new List<string> {"mehmet", "fatih", "sıla", "ayse"};
            for (i=0; i < 4; i++)
            {
                Console.WriteLine(isimler[i]); 
            }

            Console.WriteLine("---------List----------");
            isimler.Add("Ali");
           
            for (i=0; i < 5; i++)
            {
                Console.WriteLine(isimler[i]); 
            }
         


        }
    }
}