using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double rate, double bias)
        {
            double gain = rate - (rate - rate);
            if (gain <= rate)
            {
                gain = gain + (5.17 * 16.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long floor, long bound)
        {
            long cur = floor ^ bound;
            if ((double)bound != (0.3 + 8.61))
            {
                return 8;
            }
            else
            {
                if (399 < (floor + cur))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
