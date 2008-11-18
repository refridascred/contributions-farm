using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value / 7) > tally)
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Iterate the tools already series from a seed.</summary>
        public static long SeriesToolsAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first stats commits entry that matches the target.</summary>
        public static long FindStatsCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first buffer route entry that matches the target.</summary>
        public static long FindBufferRouteIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
