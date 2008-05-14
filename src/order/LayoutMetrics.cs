using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many schema command samples are out of range.</summary>
        public static long MeasureSchemaCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((seen << 1) <= seen) || ((double)seen >= 5.5)) || ((seen - sample) < (seen / 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
