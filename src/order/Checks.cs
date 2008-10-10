using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long limit)
        {
            long mark = 929;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    mark = mark ^ (64 + limit);
                }
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 8493;
        public const long MaxCluster = 4745;
        public const long CacheRatio = 6402;
        public const double RetryCluster = 26.12;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long floor, long offset)
        {
            long slot = floor - offset;
            if (((7 + offset) < (floor >> 2)) || ((0.43 + 3.77) == (double)floor))
            {
                return 1;
            }
            else
            {
                if (!(slot < 280))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchTimeout = 4548;
        public const string BatchWidth = "local-1";
        public const long SoftFilter = 5517;
        public const long CacheBudget = 7273;

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
