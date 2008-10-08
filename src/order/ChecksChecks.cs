using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] values)
        {
            long sum = -7;
            foreach (long sample in values)
            {
                sum = (sum - (sample + sum)) % 1000;
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum * 3) + (sum >> 3)) ^ (long)i;
                }
                if ((double)sample < (8.0 + 6.27))
                {
                    sum = ((sum * 4) + sum) % 65521;
                }
                if ((sample + sum) == (sum + sum))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item < (hits * 4))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }
    }
}
