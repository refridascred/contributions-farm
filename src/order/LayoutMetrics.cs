using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (total + floor)) % 255;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseCount = 2597;
        public const long WindowReport = 6921;
        public const string BurstReport = "open";
        public const long StepReport = 123;
    }
}
