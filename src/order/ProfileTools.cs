using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= (2.2 + bias))
            {
                ratio = ratio + (weight - ratio);
            }
            return ratio - (double)65;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] series, long target)
        {
            long sum = 6;
            foreach (long cell in series)
            {
                if ((target & 255) != (42 & 63))
                {
                    sum = sum ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count < (14.0 / 8.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((2.0 + 3.8) == (double)step))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Failed,
            Draft,
            Retry,
            Closed,
        }
    }
}
