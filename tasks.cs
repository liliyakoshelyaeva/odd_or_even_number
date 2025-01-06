using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework3
{
    internal class tasks
    {
        public static void Main()
        {
            //задание 2
            string[] bannedWords = new string[] { "один", "три", "пять" };
            string Text = "один два три четыре пять";
            Console.WriteLine("Задание 2:");
            Console.WriteLine("Исходный текст:" + Text);
            Text = Task2(bannedWords, Text);
            Console.WriteLine("Текст с заменёнными словами:" + Text);

            //задание 3
            //Console.WriteLine("Задание 3:");
            //string[] words = new string[] {"один, два три четыре.", "! пять шесть семь", "? восемь дeвяднадцать?" };
            //var res = Task3(words);
            //foreach (var word in res)
            //{
            //    Console.WriteLine(word);
           // }

            //задание 4
            Console.WriteLine("Задание 4:");
            string text = "ОДИН, ДВА! ТРИ? ЧЕТЫРЕ.";
            string[] lowerWords = Task4(text);
            foreach (string word in lowerWords)
            {
                Console.WriteLine(word);
            }

            //задание 5
            string input = "123456 123 12 1 22222 22 7777 77 8888 8 99999 9";
            string input1 = "123456 123 12 1 22222 22 7777 77 8888 8 99999 ";
            int result = Task5(input);
            int result1 = Task5(input1);
            Console.WriteLine("Задание 5:");
            Console.WriteLine("Количество почтовых индексов:" + result);
            Console.WriteLine("Количество почтовых индексов:" + result1);

            //задание 6
            string input2 = "123456 123 12 1 22222 22 7777 77 8888 8 99999 9";
            string input3 = "123456 123 12 1 22222 22 7777 77 8888 8 99999";
            int result2 = Task5(input2);
            int result3 = Task5(input3);
            Console.WriteLine("Задание 6:");
            Console.WriteLine("Количество почтовых индексов:" + result2);
            Console.WriteLine("Количество почтовых индексов:" + result3);
        }
        public static string Task2(string[] bannedWords, string Text)
        {
            foreach (var bannedWord in bannedWords) 
            {
                int index = Text.IndexOf(bannedWord);
                while (index != -1)
                {
                    Text = Text.Remove(index, bannedWord.Length);
                    Text = Text.Insert(index, new string('*', bannedWord.Length));
                    index = Text.IndexOf(bannedWord, index+1);
                }
            }
            return Text;
        }
        //public static string[] Task3(string[] lines)
        //{
                //if (lines == null)
                   // throw new ArgumentNullException("words");
                //var words = lines.Select(word => word.Split(new char[] { ' ', '.', ',', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)).ToArray();
                //return words;
        //}
        public static string[] Task4(string text)
        {
            string[] words = text.Split(' ', '.', ',', ':', ';', '-', '!', '?');
            for (int i = 0; i < words.Length; i++) 
            {
                words[i] = words[i].ToLower();
            }
            return words;
        }
        public static int Task5(string input)
        {
            int result = 0;
            int count = 0;
            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    count++;
                }
                if (count >= 6)
                {
                    result++;
                    count = 0;
                }
            }
            return result;
        }
        public static int Task6(string input)
        {
            string pattern = @"^\d{6}$";
            Regex regex = new Regex(pattern);
            return regex.Matches(input).Count;
        }
    }
}
