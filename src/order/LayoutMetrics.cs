using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Audit metrics format readings against a rule.</summary>
        public static long AuditMetricsFormatMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((double)item != (4.78 * 8.18)) && ((item << 2) >= item)) && ((hits > item) && ((hits ^ item) > (item >> 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
