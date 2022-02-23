using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Palindrom (string args)
        {
            string[] words = args.Split(' ','.',',',':',';','-','!','?');
            int flag = 0;
            string fullword = string.Concat(words);
            char[] letters = fullword.ToCharArray();
            for (int i = 0; i < letters.Length/2; i++)
            {
                if (letters[i] != letters[letters.Length - i - 1])
                {
                    flag = 0;
                }
                else flag = 1;
            }
            if (flag==1) Console.WriteLine("Это палиндром");
            else Console.WriteLine("Это не палиндром");
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше слово или предложение");
            string sentence = Console.ReadLine();
            Palindrom(sentence);
            Console.Read();
        }
    }
}
