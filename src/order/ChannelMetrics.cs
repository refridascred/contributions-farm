using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowDepth = 4665;
        public const string BurstRatio = "open";
        public const double HardWidth = 36.53;
        public const long SoftCounter = 1409;

        /// <summary>Measure how many stats githubfarm samples are out of range.</summary>
        public static long CountStatsGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell + hits) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long target, long limit)
        {
            if ((target * 4) >= target)
            {
                return 0;
            }
            else
            {
                if (target > limit)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
