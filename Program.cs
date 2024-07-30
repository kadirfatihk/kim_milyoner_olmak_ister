using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekrarOyna = "EVET"; // Başlangıçta döngüye girmesi için "EVET" ile başlatıyoruz

            while (tekrarOyna == "EVET")
            {
                Console.WriteLine("*******************************");
                Console.WriteLine("** KİM MİLYONER OLMAK İSTER? **");
                Console.WriteLine("*******************************");
                Console.WriteLine("\n(2 SORUYA DOĞRU CEVAP VEREN KAZANIR...)\n");

                int dogruCevapSayisi = 0;

                // Soru 1
                Console.WriteLine("SORU-1: Sapanca Gölü nerededir?");
                Console.WriteLine("A) Sakarya");
                Console.WriteLine("B) Kocaeli");
                string cevap1 = Console.ReadLine().ToUpper();

                if (cevap1 == "A")
                {
                    Console.WriteLine("\nDoğru cevap!\n");
                    dogruCevapSayisi++;
                }
                else
                {
                    Console.WriteLine("\nYanlış cevap!\n");
                }

                // Soru 2
                Console.WriteLine("SORU-2: Türkiye'de kaç coğrafi bölge vardır?");
                Console.WriteLine("A) 5");
                Console.WriteLine("B) 7");
                string cevap2 = Console.ReadLine().ToUpper();

                if (cevap2 == "B")
                {
                    Console.WriteLine("\nDoğru cevap!\n");
                    dogruCevapSayisi++;
                }
                else
                {
                    Console.WriteLine("\nYanlış cevap!\n");
                }

                // 3. Soru Kontrolü
                if (dogruCevapSayisi == 1)
                {
                    // Soru 3
                    Console.WriteLine("SORU-3: Türkiye'de kaç il vardır?");
                    Console.WriteLine("A) 81");
                    Console.WriteLine("B) 82");
                    string cevap3 = Console.ReadLine().ToUpper();

                    if (cevap3 == "A")
                    {
                        Console.WriteLine("\nDoğru cevap!\n");
                        dogruCevapSayisi++;
                    }
                    else
                    {
                        Console.WriteLine("\nYanlış cevap!\n");
                    }
                }

                // Sonuçlar
                if (dogruCevapSayisi >= 2)
                {
                    Console.WriteLine("Tebrikler! BÜYÜK ÖDÜLÜ KAZANDINIZ! 🎉");
                }
                else
                {
                    Console.WriteLine("Üzgünüm, ELENDİNİZ. 😔");
                }

                // Tekrar Oynama Seçeneği - Sadece "EVET" veya "HAYIR" kabul ediliyor
                do
                {
                    Console.Write("Tekrar oynamak ister misiniz? (Evet/Hayır): ");
                    tekrarOyna = Console.ReadLine().ToUpper();

                    if (tekrarOyna != "EVET" && tekrarOyna != "HAYIR")
                    {
                        Console.WriteLine("Lütfen 'Evet' veya 'Hayır' yazınız.");
                    }
                } while (tekrarOyna != "EVET" && tekrarOyna != "HAYIR");
            }

            Console.WriteLine("Hoşçakalın!");
            Console.ReadLine(); // Konsolu açık tutmak için
        }
    }
}