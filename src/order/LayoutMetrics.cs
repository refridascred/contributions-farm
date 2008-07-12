using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftWidth = 0.44;
        public const long SoftEditor = 2944;
        public const long BurstSize = 5982;
        public const long CacheEditor = 821;
        public const string WindowEditor = "fallback-v2";

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long bound, long limit)
        {
            if ((limit & 31) <= limit)
            {
                return 4;
            }
            else
            {
                if (((double)limit >= (3.55 / 9.0)) || (7.8 > (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (2.9 * 0.6))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound > (1.47 + 5.44))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
