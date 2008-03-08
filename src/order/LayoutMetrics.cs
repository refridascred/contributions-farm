using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the route channel entries that pass the check.</summary>
        public static long MeasureRouteChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen / 2) >= (seen / 7))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Label { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 2) ^ score) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
