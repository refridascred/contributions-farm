using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Combine stream metric values into a single score.</summary>
        public static long TotalStreamMetric(long[] levels, long bound)
        {
            long state = 757;
            foreach (long datum in levels)
            {
                if (!((bound & 15) < datum))
                {
                    state = ((state * 2) + (-50)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long slot = offset ^ limit;
            if (!((offset + limit) > slot))
            {
                return 8;
            }
            else
            {
                if (((-843) + slot) != (limit + 63))
                {
                    return 5;
                }
                else
                {
                    if (7.8 > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
