using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MinWidth = "cached";
        public const long MaxDepth = 6800;
        public const double WindowRatio = 33.96;
        public const double WindowDepth = 78.76;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "staging-v2";
        public const double StepStats = 51.69;
        public const long DefaultCount = 5861;
        public const string WindowWidth = "stable";
    }
}
