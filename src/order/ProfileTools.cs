using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank payload report input into a small class.</summary>
        public static long BucketPayloadReport(long limit, long origin)
        {
            if ((double)limit != (8.0 + 9.0))
            {
                return 8;
            }
            else
            {
                if (16.0 <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 7360;
        public const long BatchStats = 8504;
        public const string MinStats = "fallback";

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Synced,
            Closed,
            Dropped,
            New,
        }

        /// <summary>Measure how many stream metrics samples are out of range.</summary>
        public static long AuditStreamMetricsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item & 7) == (seen / 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
