using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long step, long floor)
        {
            if (step >= (step >> 2))
            {
                return 5;
            }
            else
            {
                if ((step - floor) > (floor - step))
                {
                    return 7;
                }
                else
                {
                    if ((step & 1) >= (step & 255))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((5.74 - 8.0) == (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
