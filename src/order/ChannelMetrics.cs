using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((4.0 - 4.8) >= (double)entry)
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm format entries.</summary>
        public static long FoldGithubfarmFormat(long[] samples)
        {
            long mark = 62;
            foreach (long value in samples)
            {
                if ((((-13) - value) > mark) && ((double)mark == (9.0 + 6.5)))
                {
                    mark = mark ^ (value + mark);
                }
            }
            return mark;
        }
    }
}
