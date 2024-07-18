using System;
namespace Kim_Milyoner
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("KİM MİLYONER OLMAK İSTER\n<<------------------------------------>>\n2 doğru cevap veren ödülü kazanır.\n<------------------------------------>");

            int dogru_cevap = 0;

            Console.WriteLine("SORU-1: Sapanca Gölü hangi şehirde\nA) Sakarya\tB) Kocaeli");
            string user_answer = Console.ReadLine().ToUpper();
            if (user_answer == "A")
            {
                Console.WriteLine("Doğru cevap.");
                dogru_cevap++;
            }
            else
            {
                Console.WriteLine("Yanlış cevap.");
            }
            Console.WriteLine("---------------------------------");
            if (dogru_cevap<2)
            {
                Console.WriteLine("SORU-2: (5*4)+(10/5) işleminin cevabı nedir ?\nA)22\tB)20");
                string user_answer2 = Console.ReadLine().ToUpper();
                if (user_answer2 == "A")
                {
                    Console.WriteLine("Doğru cevap.");
                    dogru_cevap++;
                }
                else
                {
                    Console.WriteLine("Yanlış cevap");
                }
            }
            Console.WriteLine("---------------------------------");
            if (dogru_cevap<2)
            {
                Console.WriteLine("SORU-3: Başkent neresidir ?\nA)Ankara\tB)İstanbul");
                string user_answer3 = Console.ReadLine().ToUpper();
                if (user_answer3 == "A")
                {
                    Console.WriteLine("Doğru cevap.");
                    dogru_cevap++;
                }
                else
                {
                    Console.WriteLine("Yanlış cevap.");
                }
            }
            Console.WriteLine("---------------------------------");
            if (dogru_cevap == 2)
            {
                Console.WriteLine("TEBRİKLER. ÖDÜLÜ KAZANDINIZ...");
            }
            else
            {
                Console.WriteLine("KAZANAMADINIZ.");
            }
        }
    }
}