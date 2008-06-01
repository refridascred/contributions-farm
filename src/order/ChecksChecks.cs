using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchWidth = 469;
        public const long SoftGithubfarm = 8853;
        public const long MaxSpan = 3011;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Validate buffer order readings against a bound.</summary>
        public static bool CheckBufferOrderBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
