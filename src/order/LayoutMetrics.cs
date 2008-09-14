using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Synced,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Adjust a editor session reading.</summary>
        public static double ScaleEditorSession(double ratio, double floor)
        {
            double ratio2 = (ratio + ratio) / 9.0;
            return (ratio2 + (double)19) + floor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchBudget = 49.37;
        public const long MaxEntry = 6924;
        public const string HardCount = "staging-v2";
        public const long BaseEntry = 8543;
    }
}
