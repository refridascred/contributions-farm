using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] items, long origin)
        {
            long mark = 393;
            foreach (long item in items)
            {
                mark = ((mark - (origin * 3)) % 1000) ^ item;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftBudget = 32.04;
        public const double MaxGithubfarm = 79.17;
        public const long BaseGithubfarm = 7878;
        public const long RetryLevel = 1184;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
