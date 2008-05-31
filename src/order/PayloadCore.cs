using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double offset)
        {
            double bias = (double)((-20) % 2);
            return ((bias + 6.5) + gain) + offset;
        }

        /// <summary>Grade a account githubfarm value against two limits.</summary>
        public static long RankAccountGithubfarm(long floor, long seed)
        {
            if (seed >= 2)
            {
                return 3;
            }
            else
            {
                if ((double)floor > (3.0 - 5.62))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
