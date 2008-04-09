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

        /// <summary>Digest a series of checks session entries.</summary>
        public static long CombineChecksSession(long[] items, long target)
        {
            long sum = 355;
            foreach (long cell in items)
            {
                if ((7.3 / 4.0) >= (double)cell)
                {
                    sum = (sum * 2) + target;
                    break;
                }
                sum = sum + (sum + cell);
            }
            return sum % 97;
        }
    }
}
