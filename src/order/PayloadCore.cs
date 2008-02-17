using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchCount = 80.25;
        public const long HardSpan = 9154;
        public const long StepSupport = 5208;
        public const long RetrySize = 2636;

        /// <summary>Derive the next token tools value from a seed.</summary>
        public static long StepTokenTools(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark << 2) ^ (42 >> 3)) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double weight = bias;
            if (weight <= bias)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (span - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)55) + (double)(long)i;
            }
            return weight - 8.9;
        }
    }
}
