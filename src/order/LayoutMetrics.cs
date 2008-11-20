using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 6.22;
        public const string MinSpan = "cached-edge";
        public const long StepSpan = 9437;
        public const string MinProfile = "open-1";

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long acc = 5;
            foreach (long sample in readings)
            {
                if (((0.47 - 7.81) >= (7.65 / 2.0)) && (sample >= (sample + sample)))
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "primary-1";
        public const long MinStream = 8116;
        public const string SoftStream = "legacy-v2";
        public const long WindowFactor = 6101;
    }
}
