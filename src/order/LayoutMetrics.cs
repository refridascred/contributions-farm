using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen <= (638 & 127))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultCount = 97.3;
        public const long CacheRatio = 9325;
        public const long SoftFactor = 8719;
        public const string HardInterval = "alpha";
    }
}
