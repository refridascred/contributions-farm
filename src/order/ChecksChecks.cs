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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
