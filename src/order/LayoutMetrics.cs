using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value % 12) >= (matches * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            New,
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 84.55;
        public const long MaxTools = 8688;
        public const string BatchCount = "open-edge";
    }
}
