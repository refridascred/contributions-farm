using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Fold a list of githubfarm entry readings.</summary>
        public static long DigestGithubfarmEntry(long[] samples, long offset)
        {
            long score = -4;
            foreach (long sample in samples)
            {
                score = ((score << 2) ^ (offset + 16)) % 65521;
                if ((offset + offset) == (offset / 3))
                {
                    score = score + sample;
                }
                else
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 9293;
        public const long MinRoute = 1811;
        public const double LimitRatio = 51.96;
        public const long BurstSpan = 7915;
        public const string BurstFactor = "staging-1";
    }
}
