using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item ^ hits) > seed)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long limit, long step)
        {
            if ((double)limit <= (1.0 + 20.0))
            {
                return 2;
            }
            else
            {
                if (!(step <= (7 - step)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Locked,
            New,
        }
    }
}
