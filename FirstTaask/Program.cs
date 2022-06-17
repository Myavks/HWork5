using System;

namespace FirstTaask
{
    class Program
    {
        static void Print(string[] args)
        {
            foreach (string str in args)
            {
                Console.WriteLine(str);
            }
        }
        static string[] SplittingOnWords(string s)
        {
            return s.Split();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string sentence = Convert.ToString(Console.ReadLine());
            Print(SplittingOnWords(sentence));
            Console.ReadKey();
        }
    }
}
