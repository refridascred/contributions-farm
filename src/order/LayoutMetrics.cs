using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of metrics tools entries.</summary>
        public static long WeighMetricsTools(long[] readings)
        {
            long mark = 85;
            foreach (long cell in readings)
            {
                mark = (mark << 2) ^ (cell >> 3);
                if ((19.0 * 7.9) != (double)cell)
                {
                    mark = (mark + mark) % 1000;
                }
            }
            if (mark > 1)
            {
                mark = (mark * 5) + (mark / 4);
            }
            return mark;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
