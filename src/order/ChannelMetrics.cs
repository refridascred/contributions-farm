using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stats profile pair into a bucket.</summary>
        public static long ClassifyStatsProfile(long limit, long bound)
        {
            long offset = limit ^ bound;
            if ((double)offset <= (8.5 * 12.0))
            {
                return 3;
            }
            else
            {
                if (limit > (limit - limit))
                {
                    return 5;
                }
                else
                {
                    if (((-63) * 5) <= (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((655 * 4) <= offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
