using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazir_Metod_Kullanimi___Split_Metodu_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Split() Metodu kullanılacak.

            Console.Write("Lütfen bir kelime girin: ");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(new char[] { ' ' });

            int kelimeSayısı = kelimeler.Length;

            Console.Write("Girdiğiniz cümlede kullanılan kelime sayısı: " + kelimeSayısı);

            Console.ReadKey();
        }
    }
}
