using System;
using System.Collections.Generic;
using System.Linq;

namespace part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.Write(i);
                    if (i < number)
                    {
                        Console.Write(", ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
            #endregion
            #region 2 
            Console.Write("Enter an integer ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(num * i);
                if (i < 12)
                {
                    Console.Write(", ");
                }
            }

            #endregion
            #region 3
             Console.Write("Enter a positive integer: ");
          int number1 = int.Parse(Console.ReadLine());

          if (number > 0)
          {
               for (int i = 1; i <= number1; i++)
                  {
                   if (i % 2 == 0)
                    {
                    Console.Write(i);
                        if (i < number1 - 1)
                        {
                        Console.Write(", ");
                   }     }
                }
           } 
        
             else
                {
            Console.WriteLine("Please enter a positive integer");
                 }

            #endregion

            #region 4
         
            Console.Write("Enter the base number ");

            int baseNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the exponent ");
            int exponent = int.Parse(Console.ReadLine());

            int result = (int)Math.Pow(baseNumber, exponent);
            Console.WriteLine($"Result: {result}");
            #endregion

            #region 5

            Console.Write("Enter a string: "); 

            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            Console.WriteLine($"Reversed String: {reversedString}");

            #endregion
            #region 6
            Console.Write("Enter an integer ");
            int integer = int.Parse(Console.ReadLine());

            int reversedinteger = 0;
            while (integer > 0)
            {
                int digit = number % 10;
                reversedinteger = reversedinteger * 10 + digit;

                number /= 10;
            }

            Console.WriteLine($"Reversed number: {reversedinteger}");
            #endregion
            #region 8
            Console.Write("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Enter the elements of array:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
            int maxDistance = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (firstOccurrence.ContainsKey(array[i]))
                {
                    int distance = i - firstOccurrence[array[i]] - 1;
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                    }
                }
                else
                {
                    firstOccurrence[array[i]] = i;
                }
            }

            Console.WriteLine($"The longest distance between two identical elements is {maxDistance} cells.");
            #endregion

            #region 9
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            Console.WriteLine(string.Join(" ", words.Reverse()));
            #endregion
        }
    }
}
