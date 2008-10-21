using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 2994;
        public const string RetryStream = "open-v2";
        public const long HardInterval = 6723;
        public const long MinFactor = 8600;
        public const long HardTimeout = 2412;

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheBudget = 4762;
        public const long CacheFormat = 8404;
        public const long WindowFormat = 7624;
        public const long IdleFormat = 5811;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Stale,
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long seed)
        {
            if ((limit << 3) < (limit >> 4))
            {
                return 2;
            }
            else
            {
                if ((seed >> 5) >= seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every session editor entry stays within the limit.</summary>
        public static bool VerifySessionEditorBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
