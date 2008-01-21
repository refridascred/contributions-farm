using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Dropped,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Validate batches token readings against a bound.</summary>
        public static bool GuardBatchesTokenBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 9168;
        public const double HardInterval = 17.54;
        public const string DefaultScore = "standard-1";

        /// <summary>Validate tools session readings against a bound.</summary>
        public static bool CheckToolsSessionLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
