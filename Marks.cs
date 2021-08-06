using System;

namespace Marks
{
    class Marks
    {
        public static string GetInput()
        {
            Console.Write("Enter numbers separated by commas(,): ");
            return Console.ReadLine();
        }
        
        public static bool IsInputvalid(string input)
        {
            string[] numbers = input.Split(',');
            int value =0;
            foreach (string number in numbers)
            {
                if (!int.TryParse(number, out value))
                {
                    Console.WriteLine("Invalid Input! There should only be numbers.");
                    return false;
                }
            }
            return true;
        }
        
        public static double CalcAvgEven(string input)
        {
            string[] list = input.Split(',');
            int sum = 0;
            int count =0;
            foreach (string num in list)
            {
                if (int.Parse(num) % 2 == 0)
                {
                    sum += int.Parse(num);
                    count++;
                }
            }
            return Math.Round((double)sum / count, 1);
        }
        
        public static double CalcAvgOdd(string input)
        {
            string[] list = input.Split(',');
            int sum = 0;
            int count =0;
            foreach (string num in list)
            {
                if (int.Parse(num) % 2 != 0)
                {
                    sum += int.Parse(num);
                    count++;
                }
            }
            return Math.Round((double)sum / count, 1);
        }
        
        public static int FindSmall(string input)
        {
            string[] score = input.Split(',');
            int small = int.Parse(score[0]);
            for (int i=1; i< score.Length; i++)
            {
                if (int.Parse(score[i]) < small)
                    small = int.Parse(score[i]);
            }
            return small;
        }
        
        public static int FindHighest(string input)
        {
            string[] score = input.Split(',');
            int highest = int.Parse(score[0]);
            for (int i=1; i< score.Length; i++)
            {
                if (int.Parse(score[i]) > highest)
                    highest = int.Parse(score[i]);
            }
            return highest;
        }
        
        public static void Main(string[] args)
        {
            string num;
            do{
                num = GetInput();
            } while(!IsInputValid(num));
            Console.WriteLine("The average even mark: "+ CalcAvgEven(num));
            Console.WriteLine("The average odd mark: "+ CalcAvgOdd(num));
            Console.WriteLine("The smallest mark: "+ FindSmall(num));
            Console.WriteLine("The highest mark: "+ FindHighest(num));
        }
    }
}
