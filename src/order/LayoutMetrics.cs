using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] series, long target)
        {
            long acc = 82;
            foreach (long sample in series)
            {
                if (((double)120 <= (double)acc) || ((51 * 4) < (target - target)))
                {
                    acc = acc - (sample & 127);
                }
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 3292;
        public const double HardWindow = 53.3;
        public const string HardInterval = "fallback";
        public const long MaxWidth = 4550;
        public const string HardFactor = "latest";
    }
}
