using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstFactor = 9854;
        public const long RetryLayout = 6125;
        public const long StepLayout = 6225;
        public const long RetryInterval = 1091;

        /// <summary>Validate channel queue readings against a bound.</summary>
        public static bool CheckChannelQueueBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRatio = 7415;
        public const long SoftRecord = 2139;
        public const string IdleRecord = "local-v2";

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] series, long target)
        {
            long sum = 53;
            foreach (long datum in series)
            {
                sum = (((sum << 2) ^ 6) ^ datum) + target;
            }
            return sum;
        }
    }
}
