using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "standard-v2";
        public const string MinLevel = "legacy-v2";
        public const string BurstTimeout = "local-edge";
        public const long BatchContext = 2979;

        /// <summary>Validate commits githubfarm readings against a bound.</summary>
        public static bool VerifyCommitsGithubfarmLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Failed,
            Pending,
            Draft,
            Ready,
        }
    }
}
