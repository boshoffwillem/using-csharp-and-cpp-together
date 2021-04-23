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

        static void Main(string[] args)
        {
            HelloWorld();
        }
    }
}
