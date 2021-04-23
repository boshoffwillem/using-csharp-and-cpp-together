using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication
{
    class Program
    {
        /// <summary>
        /// All DLL imports has to be public static.
        /// </summary>
        [DllImport("CppLibrary.dll")]
        public static extern void HelloWorld();

        [DllImport("CppLibrary.dll")]
        public static extern int Add(int x, int y);

        /// <summary>
        /// Mapping of C++ and C# primitives https://docs.microsoft.com/en-us/dotnet/framework/interop/marshaling-data-with-platform-invoke
        /// </summary>
        [DllImport("CppLibrary.dll")]
        public static extern bool IsLengthGreaterThanN(string Value, int n);

        [DllImport("CppLibrary.dll")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string GetName();

        static void Main(string[] args)
        {
            HelloWorld();
            Console.WriteLine(Add(5, 3));
            Console.WriteLine($"Is 'Hello' more than 3 characters: {IsLengthGreaterThanN("Hello", 3)}");
            Console.WriteLine($"My name is {GetName()}");
        }
    }
}
