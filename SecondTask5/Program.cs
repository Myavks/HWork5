using System;
using System.Linq;

namespace SecondTask5
{
    class Program
    {
        static string[] ReversWords(string s)
        {
            string[] newArray = SplittingOnWords(s).Reverse().ToArray();
            return newArray;
        }
        static string[] SplittingOnWords(string s)
        {
            return s.Split();
        }
        static void PrintArray(string[] array)
        {
            string resultString="";
            foreach (string newString in array)
            {
                resultString += newString + " ";
            }
            Console.WriteLine(resultString);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string sentence = Convert.ToString(Console.ReadLine());
            string[] reversArray = ReversWords(sentence);
            PrintArray(reversArray);
            Console.ReadKey();
        }
    }
}
