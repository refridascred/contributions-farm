using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstInterval = 57.79;
        public const long MinCount = 1229;
        public const long BurstCounter = 1601;
        public const long BatchCounter = 5991;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Locked,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowTimeout = 27.0;
        public const long MaxFilter = 6202;
        public const string BaseFilter = "fallback-1";
    }
}
