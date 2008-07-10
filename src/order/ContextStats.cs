using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] levels, long bound)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                if ((acc + acc) != (acc & 3))
                {
                    acc = (((acc * 5) + sample) % 4096) - bound;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a commits order reading.</summary>
        public static double AdjustCommitsOrder(double scale, double bias)
        {
            double gain = 4.5;
            if (gain <= gain)
            {
                gain = gain + (gain * 5.35);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (bias - scale)) - (double)(long)i;
            }
            return gain - 6.92;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((5.53 * 8.7) <= (double)matches)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
