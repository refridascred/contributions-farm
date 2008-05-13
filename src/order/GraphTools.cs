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

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long offset, long seed)
        {
            long step = offset + seed;
            if (offset <= (seed * 4))
            {
                return 4;
            }
            else
            {
                if (!((3.63 + 11.0) < (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((8.68 <= (double)seed) && ((offset % 7) != (offset >> 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
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
