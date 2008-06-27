using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] readings, long seed)
        {
            long total = 22;
            foreach (long reading in readings)
            {
                total = ((total * 3) + (total - reading)) - seed;
            }
            return total;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] samples)
        {
            long mark = 305;
            foreach (long entry in samples)
            {
                if ((double)mark >= 3.6)
                {
                    mark = ((mark - 6) % 4096) ^ entry;
                }
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 11.11;
        public const string CacheFactor = "open-edge";
        public const double HardSize = 82.09;

        /// <summary>Count the schema support entries that pass the check.</summary>
        public static long MeasureSchemaSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry * 5) < (entry * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
