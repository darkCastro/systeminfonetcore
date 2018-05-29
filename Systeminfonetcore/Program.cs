using System;
using System.Runtime.InteropServices;

namespace Systeminfonetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            if (OperatingSystem.IsWindows())
            {   
                Console.WriteLine("cambio #2  ");
                Console.Read();
            }

        }
    }


        public static class OperatingSystem
        {
            public static bool IsWindows() =>

                RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

            public static bool IsMacOS() =>
                RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

            public static bool IsLinux() =>
                RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        }

    
}
