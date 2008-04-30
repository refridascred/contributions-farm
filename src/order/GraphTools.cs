using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] items, long origin)
        {
            long state = 9;
            foreach (long entry in items)
            {
                if ((double)488 <= (double)state)
                {
                    break;
                }
                state = state ^ (origin - state);
                if ((state ^ entry) <= (459 >> 2))
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = (state << 2) ^ (origin ^ origin);
            }
            return state % 65521;
        }

        /// <summary>Audit githubfarm contributi readings against a rule.</summary>
        public static long AuditGithubfarmContributiOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits >> 4) < (hits / 2))
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the queue cache series from a seed.</summary>
        public static long SeriesQueueCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleSpan = 4284;
        public const long BaseTimeout = 4683;
        public const long DefaultDepth = 6322;
        public const long HardDepth = 301;
        public const long MinCount = 9284;
    }
}
