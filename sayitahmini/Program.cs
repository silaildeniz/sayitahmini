using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayitahmini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zehra = 0;
            int sila = 0;
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("SAYI TAHMİN ETME OYUNUNA HOŞGELDİN");
                Console.WriteLine("1 ile 10 dahil olmak üzere aralarından bir sayı seçiniz");
                
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Seçilen sayıyı tahmin et");

                int sayi2 = Convert.ToInt32(Console.ReadLine());


                if (sayi1 == sayi2)
                {
                    sila++;
                    Console.WriteLine("Kazandımm");
                    Console.WriteLine("Zehranın seçtiği:" + sayi1);
                    Console.WriteLine("Sılanın seçtiğin" + sayi2);
                    Console.ReadLine();

                    Console.Clear();
                }
                else if (sayi1 == sayi2)
                {
                    zehra++;
                    Console.WriteLine("Kazandınn");
                    Console.WriteLine("Sılanın seçtiği:" + sayi1);
                    Console.WriteLine("Zehranın seçtiği" + sayi2);
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {

                    Console.WriteLine("Tahmin edemediniz");
                    Console.ReadLine();
                    Console.Clear();

                }
                Console.WriteLine("********PUAN DURUMU********");
                Console.WriteLine("Sılanın skoru:" + sila);
                Console.WriteLine("Zehranın skoru:" + zehra);
                Console.ReadLine();
            }
            if (zehra > sila)
            {
                Console.Clear();
                Console.WriteLine("Oyun Sonucu: Zehra Kazandı");
                Console.ReadLine();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Oyun Sonucu: Sıla Kazandı ;)");
                Console.ReadLine();
            }
        }
    }
}
