using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a format filter value against two limits.</summary>
        public static long SortFormatFilter(long limit, long bound)
        {
            if ((double)limit <= (1.9 - 5.3))
            {
                return 4;
            }
            else
            {
                if ((432 & 31) >= bound)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)datum >= (double)87)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Idle,
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
