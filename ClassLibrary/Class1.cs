using System;
using System.Runtime.InteropServices;

namespace ClassLibrary
{
    public class Class1
    {
        [UnmanagedCallersOnly(EntryPoint ="AddOne")]
        public static int AddOne(int x)
        {
            Console.WriteLine("Inside AddOne");
            return x + 1;
        }
    }
}
