using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a contributi channel pair into a bucket.</summary>
        public static long BucketContributiChannel(long limit, long target)
        {
            if (((9 >> 5) > (limit << 1)) || (limit > (target << 1)))
            {
                return 5;
            }
            else
            {
                if (target > (limit + limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(cell <= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstFactor = 9965;
        public const long MinProfile = 5067;
        public const double LimitProfile = 20.42;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinLevel = "primary-v2";
        public const long WindowTools = 1162;
        public const long StepTools = 9529;
        public const string BatchDepth = "cached-edge";
        public const long BurstTools = 5273;
    }
}
