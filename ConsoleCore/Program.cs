using System.Runtime.InteropServices;

namespace ConsoleCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, DotNetCore");
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
