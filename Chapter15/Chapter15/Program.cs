using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace Chapter15
{
    class Program
    {
        static void Main(string[] args)
        {
           // string filename = @"..\..\sample.txt";
            //string firstFile = @"..\..\firstfile.txt";
            //string secondFile = @"..\..\secondfile.txt";
            string result = @"..\..\result.txt";
            //string names = @"..\..\listofnames.txt";
            //string sortedNames = @"..\..\sortedlistofnames.txt";
            //string newFile = @"..\..\newfile.txt";
            string xmlFile = @"..\..\xml.xml";

        }

        public static void GetDatafromXML(string filename, string result)
        {
            StreamReader reader = new StreamReader(filename);
            StreamWriter writer = new StreamWriter(result);
            StringBuilder sb = new StringBuilder();
            string str;
         //   string c = reader.ReadLine();
            using (reader)
            {
                while(reader.Peek() >= 0)
                {
                    sb.Append(reader.ReadLine());
                    
                }
            }
        }


        public static void ChangeStartOnFinish(string filename, string newFile)
        {
            StreamReader reader = new StreamReader(filename);
            StreamWriter writer = new StreamWriter(newFile);
            string line = reader.ReadLine();
            using (reader)
            {
                using (writer)
                {
                    while (line != null)
                    {
                        bool exists = line.Contains("start");
                        if (exists)
                        {
                            line = line.Replace("start", "finish");
                            writer.WriteLine(line);
                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                        line = reader.ReadLine();
                    }
                }
            }
        }



        public static void SortNames(string names, string sortedNames)
        {
            StreamReader reader = new StreamReader(names);
            StreamWriter writer = new StreamWriter(sortedNames);
            List<string> list = new List<string>();
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    list.Add(reader.ReadLine());
                }
            }
            list.Sort();
            using (writer)
            {
                foreach (var item in list)
                {
                    writer.WriteLine(item);
                }
            }

        }

        public static void GetAmountOfComparedLines(List<string> firstFileContent, List<string> secondFileContent)
        {
            int equal = 0, different = 0;
            for (int i = 0; i < firstFileContent.Capacity; i++)
            {
                if (firstFileContent[i] == secondFileContent[i])
                {
                    equal++;
                }
                else
                {
                    different++;
                }
            }
            Console.WriteLine("In compared documents there are {0} equal and {1} different lines.", equal, different);
        }

        public static List<string> SaveStringsFromFileToList(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            List<string> list = new List<string>();
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    list.Add(reader.ReadLine());
                }
            }
            return list;
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
