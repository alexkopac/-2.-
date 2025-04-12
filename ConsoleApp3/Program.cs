using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {



        
            
                
            
        
        static void Main(string[] args)
        {


            //7
            string text = @"To be, or not to be, that is the question,
Whether 'tis nobler in the mind to suffer
The slings and arrows of outrageous fortune,
Or to take arms against a sea of troubles,
And by opposing end them? To die: to sleep;
No more; and by a sleep to say we end
The heart-ache and the thousand natural shocks
That flesh is heir to, 'tis a consummation
Devoutly to be wish'd. To die, to sleep";

            string bannedWord = "die";

            // Регулярний вираз для пошуку цілого слова незалежно від регістру
            string pattern = $@"\b{Regex.Escape(bannedWord)}\b";
            int count = Regex.Matches(text, pattern, RegexOptions.IgnoreCase).Count;

            // Замінюємо на ***
            string filtered = Regex.Replace(text, pattern, "***", RegexOptions.IgnoreCase);

            // Вивід результатів
            Console.WriteLine("Відфільтрований текст:\n");
            Console.WriteLine(filtered);

            Console.WriteLine($"\nСтатистика:\n{count} заміни слова \"{bannedWord}\".");

            //2
            int[,] matrix = {
             {  10, -20,  30,  40,  50 },
             { -60,  70, -80,  90, 100 },
             { -15, -25,   5,  35, -45 },
             {  55,  65, -75,  85, -95 },
             {  15,  25, -35,  45, -56 }
         };
            
              
          

             int min = matrix[0, 0], max = matrix[0, 0];
             int minIndex = 0, maxIndex = 0;


             Console.WriteLine("Матриця:");
             for (int i = 0; i < 5; i++)
             {
                 for (int j = 0; j < 5; j++)
                 {
                     int val = matrix[i, j];
                     Console.Write(val + "\t");

                     int index = i * 5 + j;

                     if (val < min)
                     {
                         min = val;
                         minIndex = index;
                     }

                     if (val > max)
                     {
                         max = val;
                         maxIndex = index;
                     }
                 }
                 Console.WriteLine();
             }


             int start = Math.Min(minIndex, maxIndex) + 1;
             int end = Math.Max(minIndex, maxIndex);
             int sumBetween = 0;

             for (int idx = start; idx < end; idx++)
             {
                 int row = idx / 5;
                 int col = idx % 5;
                 sumBetween += matrix[row, col];
             }

             Console.WriteLine($"\nМінімальний елемент: {min}");
             Console.WriteLine($"Максимальний елемент: {max}");
             Console.WriteLine($"Сума елементів між ними: {sumBetween}");
         }



        }
    }





