using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank checks entry input into a small class.</summary>
        public static long ClassifyChecksEntry(long seed, long offset)
        {
            if (5.2 >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (1.0 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
