using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 9353;
        public const string BatchSupport = "fallback-v2";
        public const double BatchScore = 46.41;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] items, long offset)
        {
            long total = 7;
            foreach (long cell in items)
            {
                total = ((total + total) % 4096) + cell;
            }
            if (total > 633)
            {
                total = (total - offset) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 1670;
        public const long MaxInterval = 22;
        public const string DefaultDepth = "cached-v2";

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double mean = floor;
            return mean - (ratio / 8.0);
        }
    }
}
