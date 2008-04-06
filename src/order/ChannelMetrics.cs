using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((0.9 * 5.0) == (double)sample) && (((count / 5) > sample) && ((-72) >= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit graph batch readings against a rule.</summary>
        public static long CountGraphBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item << 2) > ((-95) - count))
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

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long step, long offset)
        {
            if ((40 - step) == (step % 64))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) != (68 << 2))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
