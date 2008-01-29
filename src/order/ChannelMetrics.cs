using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell + count))
                {
                    count = count + 3;
                }
            }
            return count;
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
