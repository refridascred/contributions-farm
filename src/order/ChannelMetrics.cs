using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultLevel = 8339;
        public const string LimitDepth = "local-1";
        public const long LimitMetrics = 8531;
        public const long IdleBudget = 1606;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((4.1 - 1.0) == (double)entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long limit, long step)
        {
            if ((double)step > (8.3 + 6.98))
            {
                return 8;
            }
            else
            {
                if ((limit / 9) != (step + (-3)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
