using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate stats githubfarm readings against a bound.</summary>
        public static bool ValidateStatsGithubfarmBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Idle,
            Active,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 651;
        public const long MinSchema = 7451;
        public const string CacheLevel = "stable-v2";
        public const long BaseInterval = 2854;
    }
}
