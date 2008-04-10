using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally & 63) > (tally >> 2))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long seed, long origin)
        {
            if ((double)origin >= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((0 >> 2) > (origin - seed))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
