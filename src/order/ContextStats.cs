using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the graph farm entries that pass the check.</summary>
        public static long MeasureGraphFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((66 ^ reading) <= 186)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate token format readings against a bound.</summary>
        public static bool VerifyTokenFormatRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
