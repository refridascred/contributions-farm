using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (offset >= (7 - seen))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] values, long target)
        {
            long sum = 88;
            foreach (long reading in values)
            {
                sum = ((sum + (target << 1)) % 4096) + reading;
            }
            return sum % 4096;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Derive the next farm payload value from a seed.</summary>
        public static long SeriesFarmPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!((total + total) >= total))
                {
                    total = (total + 6) % 65521;
                    total = ((total * 4) + (long)i) % 1000;
                }
                if (!(((long)i + total) < (total % 5)))
                {
                    total = ((total << 3) ^ ((long)i + seed)) % 255;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
