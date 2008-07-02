using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 94.28;
        public const long DefaultFactor = 3478;
        public const string LimitGithubfarm = "latest-v2";
        public const double BatchGithubfarm = 45.65;

        /// <summary>Check that every filter metrics entry stays within the limit.</summary>
        public static bool GuardFilterMetricsBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardFactor = 5.67;
        public const long SoftProfile = 1084;
        public const string WindowProfile = "primary-1";
        public const double StepTimeout = 45.83;
    }
}
