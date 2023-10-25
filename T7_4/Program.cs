using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //Task 1.10
                //Develop a program using the StringBuilder class that, for a given string s, 
                //removes the longest substring consisting of a repeated character from the string

                /*Write("Enter a sentence: ");
                StringBuilder s = new StringBuilder(ReadLine());

                int maxLength = 1;
                int currentLength = 1;      //Вводим изначальные счетчики
                char repeat = s[0];         //Присваиваем значение первого символа в строке, чтобы с него началось сравнение

                for(int i = 1; i < s.Length; i++)
                {
                    if (s[i] == s[i - 1])
                    {
                        currentLength++;
                        if(currentLength > maxLength)       //Сравниваем посимвольно и увеличиваем длину, если символы одинаковы, чтобы в итоге найти самую длинную подстроку
                        {
                            maxLength = currentLength;
                            repeat = s[i];
                        }
                    }
                }

                string result = s.ToString().Replace(repeat, ' ');
                Write($"Result: {result}");*/


                //Task 2.10
                //Output the words of the message in ascending order of their lengths.

                /*Write("Enter a sentence: ");
                StringBuilder s = new StringBuilder(ReadLine());
                string[] words = s.ToString().Split(' ', ',', ';', '.', ':', '!', '?', ')', '(', '"');

                Array.Sort(words);

                foreach(string word in words)
                {
                    Write($"{word}\t");
                }*/

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
