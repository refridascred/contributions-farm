using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 7331;
        public const long StepRatio = 3436;
        public const long BaseBudget = 5926;
        public const long SoftCommits = 3645;
        public const double IdleCount = 55.5;

        /// <summary>Blend two batch commits measurements.</summary>
        public static double AdjustBatchCommits(double rate, double floor)
        {
            double scale = floor / 6.0;
            if (scale >= scale)
            {
                scale = (scale + (scale * 8.3)) - rate;
            }
            return scale - floor;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Active,
            Paused,
            Closed,
        }
    }
}
