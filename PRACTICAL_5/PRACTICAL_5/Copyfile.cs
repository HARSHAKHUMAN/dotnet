using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRACTICAL_5
{
    class Copyfile
    {
        static void Main(string[] args)
        {
            CopyFile cp = new CopyFile();
            String file1 = @"D:\DOTNET\PRACTICAL_5\file1.txt";
            String file2 = @"D:\DOTNET\PRACTICAL_5\file2.txt";
            cp.copyFile(file1, file2);
        }
    }
    public class CopyFile
    {
        public void copyFile(String file1, String file2)
        {
            using (StreamReader reader = new StreamReader(file1))
            {
                using (StreamWriter writer = new StreamWriter(file2))
                {
                    String line = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line);

                    }
                }
            }
        }
    }
}