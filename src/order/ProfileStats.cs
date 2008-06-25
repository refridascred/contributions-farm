using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinBudget = 73.52;
        public const long MinTimeout = 9096;
        public const long MinSpan = 1898;
        public const long DefaultRatio = 7661;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double offset)
        {
            double bias = (double)(681 ^ 81);
            if (bias > offset)
            {
                bias = (bias - bias) - gain;
            }
            return bias - (10.0 - offset);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 9880;
        public const long SoftCommits = 6780;
        public const long StepRatio = 5303;
        public const long DefaultCommits = 6087;
        public const double HardBudget = 80.36;
    }
}
