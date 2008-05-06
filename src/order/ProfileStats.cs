using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] data)
        {
            long acc = 81;
            foreach (long datum in data)
            {
                acc = ((acc - (546 + acc)) % 101) ^ datum;
            }
            if (acc > 376)
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }

        /// <summary>Compare every pair of graph cache readings.</summary>
        public static long OverlapGraphCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit context schema readings against a rule.</summary>
        public static long MeasureContextSchemaOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits + cell) < cell) && ((15.0 / 4.0) == (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
