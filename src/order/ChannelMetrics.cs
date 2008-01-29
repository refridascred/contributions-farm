using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of token cluster readings.</summary>
        public static long TotalTokenCluster(long[] series)
        {
            long acc = 335;
            foreach (long sample in series)
            {
                if (sample < (7 ^ 0))
                {
                    acc = (acc - (sample + 7)) % 97;
                }
            }
            if (acc < (-768))
            {
                acc = (acc ^ acc) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Active,
            New,
            Paused,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long limit)
        {
            long delta = seed - limit;
            if (!(seed < ((-54) / 2)))
            {
                return 8;
            }
            else
            {
                if ((3.0 * 9.0) != (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((limit * 3) == (857 / 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (4.8 > (double)delta)
                        {
                            return 7;
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
}
