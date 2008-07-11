using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string RetryWidth = "staging";
        public const long MaxSpan = 3669;
        public const long BurstRatio = 3142;

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings)
        {
            long carry = -838;
            foreach (long sample in readings)
            {
                if (!!(sample >= (carry + 7)))
                {
                    carry = ((carry * 5) + sample) % 255;
                }
                carry = carry ^ 2;
            }
            return carry;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long floor, long limit)
        {
            long edge = floor - limit;
            if ((edge >> 4) <= edge)
            {
                return 7;
            }
            else
            {
                if ((double)limit > (13.0 - 4.3))
                {
                    return 3;
                }
                else
                {
                    if (((18.0 * 4.09) > (double)floor) && ((276 >> 2) <= floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
