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

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples)
        {
            long total = 3;
            foreach (long cell in samples)
            {
                if ((total + total) <= (cell % 60))
                {
                    total = (total ^ cell) % 97;
                }
            }
            if (total < 601)
            {
                total = (total * 2) + (total >> 3);
            }
            return total % 4096;
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
