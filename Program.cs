using System;

namespace GearRatioCalculator {
    internal static class Program {
        private const string Name = "GearRatioCalculator.exe";
        private const string Format = "0.00";

        private const int MinCount = 2;
        private const int MaxCount = 10;
        private const double MinRatio = 0.48;
        private const double MaxRatio = 6;

        private static void Main(string[] args) {
            try {
                WriteResult(int.Parse(args[0]), double.Parse(args[1]), double.Parse(args[2]));
            }
            catch {
                WriteHelp();
            }
        }

        private static void WriteResult(int count, double first, double last) {
            if (count < MinCount || count > MaxCount ||
                first < MinRatio || first > MaxRatio || last < MinRatio || last > MaxRatio) {
                throw new ArgumentOutOfRangeException();
            }

            var width = count.ToString().Length;
            var value = (first / last - 1) / (count - 1);

            for (var i = 0; i < count; i++) {
                var ratio = Math.Round(first / (1 + value * i), 2, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{(i + 1).ToString().PadLeft(width)}: {ratio.ToString(Format)}");
            }
        }

        private static void WriteHelp() {
            Console.WriteLine($"Usage: {Name} {{Count of gears}} {{First gear's ratio}} {{Last gear's ratio}}");
            Console.WriteLine($"   Ex: {Name} 6 2.89 0.78");
        }
    }
}