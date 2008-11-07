using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits >= (hits << 2))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "local";
        public const double LimitCount = 16.46;
        public const long BatchStream = 7131;
        public const double WindowStream = 53.25;
        public const long IdleStream = 338;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (offset << 2)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
