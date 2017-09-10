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
            List<int> list = new List<int>
            {
                1,
                4,
                8,
                8
                
            };


         

        }

        static int[] CalculationOccurrences(List<int> list)
        {
            int[] occurrences = new int[1001];
            for (int i = 0; i < list.Count - 1; i++)
            {
                    occurrences[i] = 1;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        occurrences[i]++;
                    }
                }
            }
            return occurrences;
        }






        static List<int> RemoveAllNegativeNumbers(List<int> list)
        {
            List<int> result = new List<int>();

            foreach (var item in list)
            {
                if (item >=0)
                {
                    result.Add(item);
                }
            }
            return result;

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
