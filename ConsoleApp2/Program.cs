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
            string[] words = args.Split(' ','.',',',':',';','-','!','?');//делю предложение
            int flag = 0;
            string fullword = string.Concat(words);//переписываю раздельные слова в одно
            char[] letters = fullword.ToCharArray();//пересобираю слово в массив чаров
            for (int i = 0; i < letters.Length/2; i++)
            {
                if (letters[i] != letters[letters.Length - i - 1])//проверяю первый и последний символ
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
