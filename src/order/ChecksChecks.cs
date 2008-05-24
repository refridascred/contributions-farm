using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits * 2) >= hits)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Validate support counter readings against a bound.</summary>
        public static bool CheckSupportCounterRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardDepth = 17.73;
        public const long IdleSize = 7068;
        public const long LimitRecord = 3459;
        public const string LimitDepth = "local-1";
    }
}
