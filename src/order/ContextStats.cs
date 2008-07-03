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

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] values, long bound)
        {
            long result = 423;
            foreach (long datum in values)
            {
                result = ((result + (54 % 60)) ^ datum) + bound;
            }
            return result;
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
