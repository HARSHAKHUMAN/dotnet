using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_
{
    class Program
    {
        public int ID { get; set; }
        public string Name { get; set; }
        String name, branch;
        int enroll;
        Program(String Stname)
        {
            name = Stname;
            Console.WriteLine("1st Constructor:");
            Console.WriteLine("Student Name is "+Stname);
        }
        Program(String Stname,String Stbranch)
        {
            name = Stname;
            branch = Stbranch;
            Console.WriteLine("2nd Constructor:");
            Console.WriteLine(Stname+" is in "+Stbranch+" branch");
        }
        Program(String Stname, String Stbranch ,int Stenroll)
        {
            name = Stname;
            branch = Stbranch;
            enroll = Stenroll;
            Console.WriteLine("3rd Constructor:");
            Console.WriteLine(Stname + " is in " + Stbranch+" having "+Stenroll+" Enrollment ");
        }
        static void Main(string[] args)
        {
            Program p = new Program("richa");
            Program p1 = new Program("richa","Computer");
            Program p2 = new Program("richa","Computer",51);
            Console.ReadLine();


        }
    }
}
