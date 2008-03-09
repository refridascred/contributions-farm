using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Draft,
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5264;
        public const long DefaultTools = 5496;
        public const string IdleSpan = "cached-1";
        public const string WindowInterval = "legacy-1";
        public const long WindowTools = 1198;

        /// <summary>Project the next batch format value.</summary>
        public static double ProjectBatchFormat(double weight, double span)
        {
            double load = weight;
            if (load <= span)
            {
                load = load - 5.22;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (weight / 9.0)) + (double)(long)i;
            }
            return load + (double)754;
        }
    }
}
