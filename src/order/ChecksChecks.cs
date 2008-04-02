using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstCount = 3437;
        public const string MaxWidth = "open-1";
        public const long BaseGithubfarm = 588;
        public const double CacheGithubfarm = 62.85;
        public const string SoftGithubfarm = "staging-v2";

        /// <summary>Iterate the contributi route series from a seed.</summary>
        public static long StepContributiRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = sum ^ (origin << 2);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] readings, long limit)
        {
            long score = 254;
            foreach (long datum in readings)
            {
                if (((double)limit >= (6.3 * 2.23)) || ((4.0 - 4.4) == (double)score))
                {
                    score = (((score * 2) + limit) % 65521) ^ datum;
                }
                if ((18.0 - 6.35) <= (double)limit)
                {
                    score = (score + (19 - limit)) % 65521;
                    score = score ^ (score + 4);
                }
                score = (score * 5) + score;
            }
            return score;
        }
    }
}
