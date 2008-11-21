using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count githubfarm entry pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultToken = 85.53;
        public const double BurstToken = 16.31;
        public const string IdleToken = "alpha-v2";

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches >= (3.56 + 8.88))
                {
                    matches = ((matches + 2) + sample) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] samples)
        {
            long score = 4;
            foreach (long sample in samples)
            {
                if ((double)7 >= (double)(long)samples.Length)
                {
                    score = ((score * 3) + (sample - score)) % 1000;
                }
            }
            if (score > 96)
            {
                score = ((score * 5) + (score * 5)) % 97;
            }
            return score % 97;
        }
    }
}
