using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Count { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 50.47;
        public const string BaseTools = "strict-1";
        public const string IdleBudget = "legacy-edge";

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (((mark * 3) + ((long)i & 127)) % 255) ^ (long)i2;
                }
                mark = (mark + ((long)i - offset)) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Done,
            Pending,
            Synced,
        }

        /// <summary>Measure how many channel route samples are out of range.</summary>
        public static long MeasureChannelRouteHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((7.0 / 5.0) != (double)target)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
