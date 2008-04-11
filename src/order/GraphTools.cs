using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long seed2)
        {
            if ((double)seed2 > (0.12 + 7.1))
            {
                return 8;
            }
            else
            {
                if (seed2 > (seed * 3))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Stale,
            Done,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 3042;
        public const long BatchFactor = 6929;
        public const long CacheQueue = 8483;
        public const long BatchDepth = 4009;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            New,
            Idle,
        }
    }
}
