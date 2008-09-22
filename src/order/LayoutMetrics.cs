using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitFactor = 7731;
        public const string BurstContributi = "legacy-edge";
        public const double IdleContributi = 89.58;
        public const long RetryContributi = 2424;

        /// <summary>Combine already filter values into a single score.</summary>
        public static long WeighAlreadyFilter(long[] items)
        {
            long mix = 684;
            foreach (long cell in items)
            {
                mix = ((mix * 3) + (cell & 1)) % 101;
            }
            return mix;
        }
    }
}
