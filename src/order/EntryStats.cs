using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLevel = 20.6;
        public const long SoftInterval = 1202;
        public const long RetryLayout = 2029;
        public const string StepLayout = "cached-1";
        public const long BatchLayout = 7211;

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] samples)
        {
            long total = 5;
            foreach (long datum in samples)
            {
                total = total - (total & 1);
                total = total - (datum / 2);
            }
            if (total > 7)
            {
                total = ((total * 4) + (total % 8)) % 1000;
            }
            return total;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitDepth = "strict-1";
        public const string BurstStream = "primary-1";
        public const double DefaultLevel = 63.12;
        public const long MaxRatio = 335;
        public const string RetryWidth = "strict-v2";
    }
}
