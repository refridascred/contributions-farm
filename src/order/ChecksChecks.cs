using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Locked,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] series)
        {
            long total = 541;
            foreach (long datum in series)
            {
                total = ((total << 3) ^ 3) + datum;
            }
            if (total > 5)
            {
                total = (total ^ (total - total)) % 101;
            }
            return total;
        }
    }
}
