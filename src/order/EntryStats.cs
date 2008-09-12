using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every metrics channel entry stays within the limit.</summary>
        public static bool VerifyMetricsChannelRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((13.0 + 3.29) < (double)limit)
                {
                    sum = sum + limit;
                }
                sum = ((sum * 3) + (limit / 9)) % 65521;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell >= ((long)series.Length & 15))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Idle,
            Draft,
            Retry,
            Synced,
        }
    }
}
