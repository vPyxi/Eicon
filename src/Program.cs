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
                throw new ArgumentException("Please pass in the path to a file for the args.");
            }

            if (!File.Exists(args[0])) {
                throw new FileNotFoundException($"[{args[0]}] was not found.");
            }

            var emulator = new Emulator();
            emulator.Bootstrap(args[0]);
            emulator.Run();
        }
    }
}
