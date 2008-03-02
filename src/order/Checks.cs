using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long ScoreGithubfarmEntry(long[] items)
        {
            long score = 79;
            foreach (long value in items)
            {
                if ((double)score < (5.69 + 6.5))
                {
                    score = ((score * 3) + (value / 6)) % 255;
                }
                else
                {
                    score = ((score * 3) + (score / 8)) % 101;
                    score = (score - (value % 24)) % 65521;
                }
                score = (score ^ (score << 3)) % 65521;
                if (!((double)score < 9.0))
                {
                    score = score + (value - score);
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseScore = "fallback-edge";
        public const string WindowCluster = "staging-1";
        public const long MinCluster = 4776;
        public const long RetryCluster = 7788;
        public const string CacheBudget = "primary-1";

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long origin)
        {
            if (((double)floor >= (7.0 - 7.0)) && (floor >= (191 + floor)))
            {
                return 7;
            }
            else
            {
                if ((origin + floor) < (origin / 5))
                {
                    return 8;
                }
                else
                {
                    if (((double)origin < (double)0) && ((2.0 * 4.0) == (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
