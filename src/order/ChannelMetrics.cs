using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 2) + (983 - (-808))) % 101;
                if ((origin << 2) >= mix)
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
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
