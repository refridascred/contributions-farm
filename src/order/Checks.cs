using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Dropped,
            Queued,
            Stale,
            Active,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long limit, long step)
        {
            long span = limit + step;
            if ((68 + step) != (span << 3))
            {
                return 7;
            }
            else
            {
                if ((step & 255) <= 207)
                {
                    return 8;
                }
                else
                {
                    if (0.82 >= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
