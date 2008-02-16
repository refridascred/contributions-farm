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

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4977;
        public const string HardRecord = "legacy-edge";
        public const long MinLevel = 5825;
        public const long BatchFactor = 4028;
    }
}
