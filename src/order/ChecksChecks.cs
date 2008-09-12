using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of farm entry entries.</summary>
        public static long FoldFarmEntry(long[] levels)
        {
            long score = 58;
            foreach (long entry in levels)
            {
                if ((9 + 3) <= (score % 12))
                {
                    score = (score - score) % 1000;
                }
                if ((double)score > (7.1 / 2.0))
                {
                    score = (score ^ (2 + entry)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] levels)
        {
            long anchor = 321;
            foreach (long datum in levels)
            {
                if (5 > (anchor + anchor))
                {
                    anchor = (anchor << 3) ^ ((long)levels.Length + 363);
                }
                else
                {
                    anchor = (anchor << 3) ^ (datum + anchor);
                }
            }
            return anchor % 1000;
        }
    }
}
