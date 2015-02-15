using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace KadirKernel
{
    public class Kernel : Sys.Kernel
    {
        private string path;

        protected override void BeforeRun()
        {
            Console.WriteLine("Starting Kadir...");
            Console.WriteLine();
            Console.WriteLine();
            path = "C:\\";
        }

        protected override void Run()
        {
            Console.Write(path + ">");
            var input = Console.ReadLine();
            var line = input.Trim();
            switch (line)
            {
                case "ver":
                    Console.WriteLine();
                    Console.WriteLine("Kadir Version 0.1");
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }
    }
}