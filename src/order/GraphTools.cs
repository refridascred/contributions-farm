using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long limit)
        {
            if ((double)limit != (8.0 * 1.5))
            {
                return 6;
            }
            else
            {
                if ((seed * 5) == (seed / 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] samples, long target)
        {
            long anchor = 27;
            foreach (long value in samples)
            {
                if (!((value ^ value) <= (anchor - anchor)))
                {
                    anchor = (anchor - value) + target;
                }
            }
            if (anchor > 948)
            {
                anchor = ((anchor * 2) + (9 + anchor)) % 97;
            }
            return anchor % 1000;
        }
    }
}
