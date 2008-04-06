using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Failed,
            Stale,
            Locked,
            Idle,
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
