using System.Runtime.InteropServices;

namespace ConsoleApplication
{
    [StructLayout(LayoutKind.Sequential)] // This tells the P/Invoke marshaler
    // how to marshal the struct to/from C++.
    public struct Shoe
    {
        public int Id;

        [MarshalAs(UnmanagedType.BStr)]
        public string Color;

        public double Size;

        [MarshalAs(UnmanagedType.BStr)]
        public string Brand;
    }
}
