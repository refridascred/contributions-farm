using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long seed)
        {
            if ((double)offset <= (1.0 - 7.0))
            {
                return 4;
            }
            else
            {
                if (((4.6 * 13.0) >= (double)offset) || ((seed + seed) < (offset << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= 8.77)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Closed,
            Done,
        }
    }
}
