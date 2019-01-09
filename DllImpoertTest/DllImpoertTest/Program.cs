using System;
using System.Runtime.InteropServices;

namespace DllImpoertTest
{
    class DllImpoertTest
    {
        [DllImport("User32.Dll")]
        public static extern int MessageBox(int h, string m, string c, int type);

        static void Main(string[] args)
        {
            MessageBox(0, "Hello!", "In C#", 0);
        }
    }
}
