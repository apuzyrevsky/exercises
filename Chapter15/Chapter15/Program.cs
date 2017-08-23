using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter15
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"..\..\sample.txt";
            string firstFile = @"..\..\firstfile.txt";
            string secondFile = @"..\..\secondfile.txt";
            string result = @"..\..\result.txt";

        }

        public static void SaveTextFromOneFileToAnother(string filename, string result)
        {

            StreamReader reader = new StreamReader(filename);
            StreamWriter writer = new StreamWriter(result, true);
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                writer.WriteLine(line);
                line = reader.ReadLine();
            }
            reader.Close();
            writer.Close();
        }

        public static void PrintOddLines(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            int lineNumber = 0;
            string line = reader.ReadLine();
            using (reader)
            {
                while (line != null)
                {
                    lineNumber++;
                    if (IsOdd(lineNumber))
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                }
            }
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
