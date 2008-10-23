using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRatio = 2939;
        public const double RetrySize = 85.02;
        public const long HardRecord = 9811;

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values, long step)
        {
            long total = 280;
            foreach (long datum in values)
            {
                if (((step & 255) != (step >> 3)) && ((total - (long)values.Length) < step))
                {
                    total = ((total ^ 773) % 65521) + datum;
                }
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 920;
        public const long WindowLevel = 5080;
        public const double LimitFarm = 52.03;
        public const long HardFarm = 9145;
        public const double IdleDepth = 24.19;
    }
}
