using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;


namespace auto_final
{
    internal class Program1
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadProcessMemory(IntPtr process, IntPtr baseAddress, [Out] byte[] buffer, int size,
            out IntPtr bytesRead);

        public static long ReadInt64(IntPtr process, IntPtr baseAddress)
        {
            var buffer = new byte[8];
            IntPtr bytesRead;
            ReadProcessMemory(process, baseAddress, buffer, 4, out bytesRead);
            return BitConverter.ToInt64(buffer, 0);
        }

        private static ProcessModule GetProcessModule(Process process, string moduleName)
        {
            foreach (ProcessModule module in process.Modules)
            {
                if (module.ModuleName == moduleName)
                {
                    return module;
                }
            }
            return null;
        }

        public static long GetRealAddress(IntPtr process, IntPtr baseAddress, int[] offsets)
        {
            var address = baseAddress.ToInt64();
            foreach (var offset in offsets)
            {
                address = ReadInt64(process, (IntPtr)address) + offset;

            }
            return address;
        }

        public static void getdata()
        {
           // Console.WriteLine(Environment.Is64BitProcess);

            // Get the first Chrome process that contains a module named "pepflashplayer.dll".
            var chromeProcess =
                Process.GetProcessesByName("dragonsaga")
                    .FirstOrDefault();

            if (chromeProcess != null)
            {
                var buffer = new byte[8];
                var buffer2 = new byte[8];
                IntPtr lpsize;
                var flashPlayerModule = GetProcessModule(chromeProcess, "dragonsaga.exe");
                var baseAddress = flashPlayerModule.BaseAddress.ToInt64() + 0x0140C9D4;
                var offsets = new[] { 0x58, 0xc, 0x0, 0x4, 0x10 };
                var realAddress = GetRealAddress(chromeProcess.Handle, (IntPtr)baseAddress, offsets);

                var baseAddress2 = flashPlayerModule.BaseAddress.ToInt64() + 0x0140C9D8;
                var offsets2 = new[] { 0xC, 0x0, 0x4, 0x8, 0x10 };
                var realAddress2 = GetRealAddress(chromeProcess.Handle, (IntPtr)baseAddress2, offsets2);

                //Console.WriteLine(realAddress.ToString("X"));
                while (true)
                {
                    var value = ReadProcessMemory(chromeProcess.Handle, (IntPtr)realAddress, buffer, 4, out lpsize);
                    var heahlt = BitConverter.ToInt32(buffer, 0);
                    var value2 = ReadProcessMemory(chromeProcess.Handle, (IntPtr)realAddress2, buffer2, 4, out lpsize);
                    var mana = BitConverter.ToInt32(buffer2, 0);
                    //Console.WriteLine("Health: {0}", heahlt.ToString());
                    
                    //Console.WriteLine("Mana: {0}", mana.ToString());

                    Thread.Sleep(1000);
                   // Console.Clear();

                }

                //Console.ReadLine();
            }
        }
    }
}

