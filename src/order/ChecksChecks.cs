using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((8.9 + 4.3) == (double)value) || ((matches & 1) < (5 << 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double bias)
        {
            double load = 13.0;
            if (load > (double)2)
            {
                load = ((load + (double)709) + scale) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - 5.9) + (double)(long)i;
            }
            return load + 9.68;
        }
    }
}
