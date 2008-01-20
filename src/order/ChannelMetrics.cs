using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitBudget = 5781;
        public const double RetryDepth = 20.31;
        public const long DefaultScore = 7265;
        public const double SoftGithubfarm = 37.98;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long floor, long origin)
        {
            if ((floor - floor) < origin)
            {
                return 5;
            }
            else
            {
                if ((double)origin <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
