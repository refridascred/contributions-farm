using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + 18) >= (value << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 47.29;
        public const long RetrySize = 5968;
        public const string BatchScore = "local";

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double drift = 7.0;
            if (drift <= 7.6)
            {
                drift = (drift + gain) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (9.5 * 18.0)) - (double)(long)i;
            }
            return drift - (double)11;
        }
    }
}
