using System;
namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KİM MİLYONER OLMAK İSTER ?\n\n(2 SORUYA DOĞRU CEVAP VEREN KAZANIR...)\n<---------------------------------------->)");
            int true_answer = 0;

            Console.WriteLine("SORU-1: Sapanca Gölü nerdedir ?\nA) Sakarya\tB) Kocaeli");
            string user_answer1 = Console.ReadLine().ToUpper();
            if (user_answer1 == "A")
            {
                Console.WriteLine("Doğru cevap.\n--------------------------");
                true_answer++;
            }
            else
            {
                Console.WriteLine("Yanlış cevap.\n--------------------------");
            }

            Console.WriteLine("SORU-2: Türkiye'de kaç bölge var ?\nA) 5\tB) 7");
            string user_answer2 = Console.ReadLine().ToUpper();
            if (user_answer2 == "B")
            {
                Console.WriteLine("Doğru cevap.\n--------------------------");
                true_answer++;
            }
            else
            {
                Console.WriteLine("Yanlış cevap.\n--------------------------");
            }
            if (true_answer ==1)
            {
                Console.WriteLine("SORU-3: Kaç şehir var ?\nA) 81\tB) 82");
                string user_answer3 = Console.ReadLine().ToUpper();
                if (user_answer3 == "A")
                {
                    Console.WriteLine("Doğru cevap.\n--------------------------");
                    true_answer++;
                }
                else
                {
                    Console.WriteLine("Yanlış cevap.\n--------------------------");
                }
            }
            if (true_answer >= 2)
            {
                Console.WriteLine("BÜYÜK ÖDÜLÜ KAZANDINIZ...");
            }
            else
            {
                Console.WriteLine("ELENDİNİZ.");
            }
        }
    }
}