using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next format graph value from a seed.</summary>
        public static long SeriesFormatGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                long count = (offset ^ offset) - (832 - 76);
                state = (state * 5) + ((long)i - count);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long limit, long limit2)
        {
            long prev = limit ^ limit2;
            if ((double)limit2 != (7.8 * 5.0))
            {
                return 8;
            }
            else
            {
                if (((double)limit <= (double)780) && ((limit2 ^ prev) >= prev))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
