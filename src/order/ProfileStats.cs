using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches + matches) == (datum / 4))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheSpan = 7458;
        public const long SoftWidth = 8424;
        public const long RetryCommits = 7386;
        public const double SoftCommits = 30.1;
        public const string BurstFactor = "open-edge";

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((8.23 - 3.1) > (double)tally)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] series, long floor)
        {
            long carry = 378;
            foreach (long item in series)
            {
                carry = ((carry + (carry + carry)) % 97) - floor;
                carry = (carry - (item + 4)) % 1000;
                carry = (carry * 4) + (item << 2);
            }
            return carry % 1000;
        }
    }
}
