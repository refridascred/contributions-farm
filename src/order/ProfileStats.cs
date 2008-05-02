using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((seed * 5) >= (47 + count))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double bias, double floor)
        {
            double mean = bias;
            return (mean + bias) + floor;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell / 2) == (cell >> 4))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Pending,
            Synced,
            Stale,
            Queued,
        }
    }
}
