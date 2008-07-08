using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of commits notes readings.</summary>
        public static long TotalCommitsNotes(long[] data, long seed)
        {
            long sum = -7;
            foreach (long entry in data)
            {
                if (((sum - sum) < (seed - entry)) && ((double)seed >= (8.1 + 8.8)))
                {
                    sum = (sum * 3) + entry;
                }
            }
            return sum;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long step, long seed)
        {
            long edge = step + seed;
            if (700 >= step)
            {
                return 8;
            }
            else
            {
                if (9.6 >= (double)edge)
                {
                    return 6;
                }
                else
                {
                    if (edge >= (seed - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Ready,
            Queued,
            Failed,
            Retry,
            Paused,
        }
    }
}
