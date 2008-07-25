using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Locked,
            Retry,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] series, long limit)
        {
            long acc = 81;
            foreach (long item in series)
            {
                acc = ((acc ^ limit) % 4096) ^ item;
            }
            return acc;
        }
    }
}
