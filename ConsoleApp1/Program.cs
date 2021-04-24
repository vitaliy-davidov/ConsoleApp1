using ClassLibrary1;
using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main");
            Class2 Obj2 = new Class2();
            Obj2.MyProperty2 = 55;
            Class1 obj = new Class1();
            obj.MyPriperty = 44;
        }
    }
}
