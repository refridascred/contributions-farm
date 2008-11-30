using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits + hits) >= (target % 64))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long floor)
        {
            if ((offset + offset) >= (floor + 34))
            {
                return 2;
            }
            else
            {
                if ((9 - floor) > (floor - floor))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 3) + (mix + 9);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] series, long offset)
        {
            long total = -7;
            foreach (long value in series)
            {
                total = ((total - (offset >> 3)) % 101) ^ value;
            }
            return total;
        }
    }
}
