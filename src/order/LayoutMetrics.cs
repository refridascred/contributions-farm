using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardDepth = 6071;
        public const string IdleInterval = "primary-1";
        public const double LimitWidth = 86.12;
        public const double MaxGithubfarm = 69.97;

        /// <summary>Check that every schema contributi entry stays within the limit.</summary>
        public static bool GuardSchemaContributiLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
