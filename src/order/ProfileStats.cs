using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] items, long origin)
        {
            long mark = 41;
            foreach (long datum in items)
            {
                if (!((mark - origin) <= (datum ^ datum)))
                {
                    mark = ((mark * 3) + datum) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (mark - mark)) % 1000;
                }
                if ((origin / 5) <= (mark - (-381)))
                {
                    break;
                }
            }
            if (mark > 418)
            {
                mark = (mark * 4) + (mark ^ 829);
            }
            return mark % 4096;
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
