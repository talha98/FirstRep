using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
            ClassLibrary.Class1 sc = new ClassLibrary.Class1();
            string outp = sc.CallMe(" Talha");
            Console.WriteLine(outp);
            Console.ReadLine();
        }
    }
}
