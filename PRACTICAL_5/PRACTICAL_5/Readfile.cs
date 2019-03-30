﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRACTICAL_5
{
    class Readfile
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"D:\DOTNET\PRACTICAL_5\file1.txt");
            using (reader)
            {
                int lineNumber = 0;
                String line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}:{1}", lineNumber, line);
                    line = reader.ReadLine();
                }
                Console.ReadLine();
            }
        }
    }
}