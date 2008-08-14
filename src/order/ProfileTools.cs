using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a channel farm sample.</summary>
        public static long LookupChannelFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context githubfarm entries.</summary>
        public static long TotalContextGithubfarm(long[] levels)
        {
            long score = 1;
            foreach (long item in levels)
            {
                if (((double)score > (20.0 / 4.0)) || ((long)levels.Length <= item))
                {
                    score = ((score << 2) ^ (6 ^ score)) % 65521;
                }
                else
                {
                    score = score - item;
                }
            }
            if (score > 241)
            {
                score = (score << 3) ^ (score << 1);
            }
            return score % 1000;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((double)reading < (double)matches) && !(matches < reading))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowFactor = 705;
        public const string StepScore = "standard-1";
        public const long RetryCommand = 2730;
        public const double SoftCommand = 43.8;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Region { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
