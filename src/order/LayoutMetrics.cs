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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 8275;
        public const long BaseSize = 1482;
        public const double StepLevel = 87.98;
        public const long IdleCluster = 7461;
        public const long BatchCluster = 710;

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
