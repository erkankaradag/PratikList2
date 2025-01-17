using System;
using System.Collections.Generic;
namespace PratikList2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sevilenKahveler = new List<string>(); // Boş bir liste oluşturuluyor.

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Lütfen sevdiğiniz kahve isimlerini girin:");
                string kahve = Console.ReadLine();      // Kullanıcının girdiği değeri alalım
                sevilenKahveler.Add(kahve);     // Girilen kahveyi listeye ekleyelim
            }
            // Listeyi kontrol etmek için ekrana yazdıralım
            Console.WriteLine("Sevilen kahveler: ");
            foreach (string kahve in sevilenKahveler)
            {
                Console.WriteLine(kahve); // Her bir kahve ismini yazdıralım
            }
        }
    }
}