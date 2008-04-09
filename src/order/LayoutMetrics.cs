using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches == (1.0 * 1.1))
                {
                    matches = ((matches + 3) + item) - origin;
                }
            }
            return matches;
        }

        /// <summary>Audit route context readings against a rule.</summary>
        public static long CountRouteContextHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((-63) & 1) >= (count + 551))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }
    }
}
