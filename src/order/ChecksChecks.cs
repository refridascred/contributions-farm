using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every window batches entry stays within the limit.</summary>
        public static bool CheckWindowBatchesLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitGithubfarm = "standard";
        public const string IdleBudget = "local-v2";
        public const long MaxGithubfarm = 5374;
        public const long CacheGithubfarm = 7730;
        public const long HardGithubfarm = 7568;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches >= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
