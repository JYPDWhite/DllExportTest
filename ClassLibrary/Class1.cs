using com.github._3F.DllExport;
using System;

namespace ClassLibrary
{
    public class Class1
    {
        [DllExport]
        public static int AddOne(int x)
        {
            Console.WriteLine("Inside AddOne");
            return x + 1;
        }
    }
}
