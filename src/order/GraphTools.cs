using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double offset)
        {
            double weight = ratio;
            if (weight < (weight - 3.0))
            {
                weight = weight - (6.95 + offset);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (offset / 5.0)) + (double)(long)i;
            }
            return weight + (weight / 4.0);
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] readings, long seed)
        {
            long carry = 22;
            foreach (long sample in readings)
            {
                carry = ((carry + sample) % 4096) - seed;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "staging-edge";
        public const string MaxFormat = "cached-edge";
        public const long MaxTimeout = 7498;
        public const double WindowSpan = 80.36;
        public const long HardRatio = 2795;
    }
}
