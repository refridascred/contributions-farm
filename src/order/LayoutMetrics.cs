using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Score { get; set; }
            public double Mode { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((38 ^ count) < (value & 15))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
