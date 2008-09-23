using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long limit, long step)
        {
            long gap = limit ^ step;
            if ((double)gap > (double)497)
            {
                return 7;
            }
            else
            {
                if ((step * 3) > (limit % 5))
                {
                    return 3;
                }
                else
                {
                    if ((limit + 8) < (gap ^ limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((gap + limit) > (step % 97))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardDepth = 2046;
        public const long CacheContext = 3000;
        public const string WindowScore = "staging-v2";

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Closed,
            Dropped,
            Ready,
            Locked,
            Retry,
        }
    }
}
