using System;
using System.IO;
using Eicon.Emulation;

namespace Eicon
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) {
                System.Console.WriteLine($"Please pass a command-line argument pointing to the ROM to load.");
                return;
            }

            if (!File.Exists(args[0])) {
                System.Console.WriteLine($"The given file does not exist: [{args[0]}].");
                return;
            }

            var emulator = new Emulator();
            emulator.Bootstrap(args[0]);
            emulator.Run();
        }
    }
}
