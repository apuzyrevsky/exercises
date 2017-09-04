using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Chapter16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(4);
            list.Add(9);
            list.Add(8);
            list.Add(8);
            list.Add(9);
            list.Add(9);
            list.Add(9);
            list.Add(9);
            list.Add(9);
            list.Add(9);
            list.Add(9);




        }

        static List<int> GetLongestSubsequence(List<int> list)
        {
            List<int> result = new List<int>();
            int n = 0, length = 1;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list.ElementAt(i) == list.ElementAt(i + 1))
                {
                    n = list.ElementAt(i);
                    length++;
                }
                else
                {
                    length = 1;
                }
            }
            while (length != 0)
            {
                result.Add(n);
                length--;
            }
            return result;
        }

        static void GetReverseNumbersByStack()
        {
            string i;
            Stack<int> stack = new Stack<int>();
            do
            {
                Console.WriteLine("Enter a sequence of numbers:");
                i = Console.ReadLine();
                if (int.TryParse(i, out int n))
                {
                    stack.Push(n);
                    i = " ";
                }
            } while (i != String.Empty);
            while (stack.Count > 0)
            {
                int n = stack.Pop();
                Console.WriteLine(n);
            }
        }
        static void GetSumAndAverage()
        {
            List<int> list = new List<int>();
            string i;
            do
            {
                Console.WriteLine("Enter a sequence of numbers:");
                i = Console.ReadLine();
                if (int.TryParse(i, out int n))
                {
                    list.Add(n);
                    i = " ";
                }
            } while (i != String.Empty);

            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            double average = list.Average();
            Console.WriteLine("The sum of numbers: {0}", sum);
            Console.WriteLine("The average of numbers: {0}", average);
        }
    }
}
