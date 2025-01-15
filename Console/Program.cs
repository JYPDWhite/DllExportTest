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
            Console.WriteLine("Hello, Net Framework");
            try
            {
                Console.WriteLine("1+1=" + AddOne(1));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }

        [DllImport("ClassLibrary.dll")]
        private static extern int AddOne(int x);
    }
}
