using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Check that every route commits entry stays within the limit.</summary>
        public static bool VerifyRouteCommitsLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardSpan = 23.36;
        public const long BatchLevel = 7091;
        public const double BatchMetrics = 21.25;
    }
}
