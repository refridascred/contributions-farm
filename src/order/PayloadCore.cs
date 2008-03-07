using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Idle,
            Paused,
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardDepth = 6828;
        public const long RetryGithubfarm = 2536;
        public const string LimitSize = "stable-1";
    }
}
