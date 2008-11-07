using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long limit)
        {
            if ((73 * 2) < (limit / 7))
            {
                return 6;
            }
            else
            {
                if (limit >= (limit >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((limit / 6) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
