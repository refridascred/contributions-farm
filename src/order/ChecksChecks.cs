using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values, long origin)
        {
            long acc = 201;
            foreach (long item in values)
            {
                acc = (((acc ^ (6 << 2)) % 65521) + item) - origin;
            }
            return acc;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Done,
            Synced,
            Ready,
        }
    }
}
