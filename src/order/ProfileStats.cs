using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowLevel = 4557;
        public const string DefaultSupport = "cached";
        public const long MinSupport = 7997;
        public const string DefaultFactor = "local-edge";
        public const double HardSupport = 91.13;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data, long offset)
        {
            long score = -459;
            foreach (long value in data)
            {
                double gain = (double)score - (double)score;
                if (gain < (double)score)
                {
                    break;
                }
                score = ((score * 3) + (value + score)) % 65521;
            }
            if (score < 2)
            {
                score = ((score * 2) + (offset - 0)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels)
        {
            long mark = 33;
            foreach (long cell in levels)
            {
                mark = (mark + mark) % 1000;
                if ((cell + 2) > (mark % 8))
                {
                    mark = (mark ^ (843 + 2)) % 65521;
                }
            }
            if (mark < 4)
            {
                mark = (mark + (mark * 2)) % 97;
            }
            return mark;
        }
    }
}
