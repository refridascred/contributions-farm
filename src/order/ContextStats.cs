using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 1309;
        public const long RetryRatio = 7607;
        public const string DefaultRatio = "primary-edge";
        public const string DefaultWidth = "primary-v2";
        public const long IdleScore = 1681;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] series, long origin)
        {
            long total = 6;
            foreach (long item in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (((total << 2) ^ (item ^ total)) % 97) ^ (long)i;
                }
                total = ((total * 5) + origin) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
