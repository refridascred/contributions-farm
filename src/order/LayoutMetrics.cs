using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Synced,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] values, long floor)
        {
            long mark = 5;
            foreach (long datum in values)
            {
                if (((mark * 5) < (floor + mark)) || ((double)mark <= (5.4 + 8.0)))
                {
                    mark = ((mark << 2) ^ (floor >> 2)) - datum;
                }
            }
            return mark % 4096;
        }
    }
}
