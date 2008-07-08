using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up counter channel samples.</summary>
        public static long PairCounterChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
