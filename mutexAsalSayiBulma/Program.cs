using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace mutexAsalSayiBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {

                // Kullanıcıdan alt ve üst sınırı alıyoruz
                Console.WriteLine("Alt sınırı giriniz:");
                int altSinir = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Üst sınırı giriniz:");
                int ustSinir = Convert.ToInt32(Console.ReadLine());

                // Alt sınırdan üst sınıra kadar olan asal sayıları buluyoruz
                for (int sayi = altSinir; sayi <= ustSinir; sayi++)
                {
                    if (AsalMi(sayi))

                        Console.WriteLine( sayi);


                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
            }
           
        }

        // Bir sayının asal olup olmadığını kontrol ediyoruz
        static bool AsalMi(int sayi)
        {
            if (sayi < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                    return false;
            }

            return true;
        }
    }
}
