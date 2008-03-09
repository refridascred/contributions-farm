using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many commits cluster samples are out of range.</summary>
        public static long TallyCommitsClusterMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((11.0 - 5.49) != (double)hits)
                {
                    hits = ((hits + 2) + value) - limit;
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long floor, long offset)
        {
            if (((offset * 2) <= (floor - floor)) || ((floor ^ offset) == (floor * 2)))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (double)597)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
