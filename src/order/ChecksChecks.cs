using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultScore = 5545;
        public const long StepWidth = 6665;
        public const long BaseBudget = 7750;
        public const string HardSpan = "legacy-v2";

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
