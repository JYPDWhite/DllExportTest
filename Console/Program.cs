using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("1+1=" + AddOne(1));


            Console.ReadKey();
        }

        [DllImport("ClassLibrary.dll")]
        private static extern int AddOne(int x);
    }
}
