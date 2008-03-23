using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long anchor = 17;
            foreach (long datum in samples)
            {
                anchor = anchor + (anchor ^ 603);
                anchor = (anchor - (3 + datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryLevel = 1638;
        public const long RetryBudget = 8532;
        public const double MinBatch = 88.47;
        public const string BaseBatch = "fallback-v2";
        public const double SoftBatch = 84.21;

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseFactor = "staging-v2";
        public const long IdleInterval = 5355;
        public const long BurstRoute = 5472;
        public const long DefaultTimeout = 4319;
    }
}
