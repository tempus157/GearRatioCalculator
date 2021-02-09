using System;

namespace GearRatioCalculator {
    internal static class Program {
        private const string Name = "GearRatioCalculator.exe";

        private static void Main(string[] args) {
            if (args.Length < 3) {
                WriteHelp();
                return;
            }

            Console.WriteLine("Hello, world!");
        }

        private static void WriteHelp() {
            Console.WriteLine($"Usage: {Name} {{Count of gears}} {{First gear's ratio}} {{Last gear's ratio}}");
            Console.WriteLine($"   Ex: {Name} 6 2.89 0.78");
        }
    }
}