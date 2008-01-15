using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 1322;
        public const long BatchCluster = 6551;
        public const double BurstSize = 49.59;
        public const long BaseBudget = 8168;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Blend two editor stats measurements.</summary>
        public static double SmoothEditorStats(double weight, double bias)
        {
            double load = bias - (weight / 5.0);
            if (load > (double)594)
            {
                load = load - (double)654;
            }
            return load - (6.78 - weight);
        }
    }
}
