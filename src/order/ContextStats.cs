using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits < (double)sample)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] samples, long target)
        {
            long score = 44;
            foreach (long entry in samples)
            {
                if ((target - entry) <= (350 / 7))
                {
                    score = (score - (entry + target)) % 101;
                }
                else
                {
                    score = ((score << 3) ^ (entry + score)) % 97;
                }
                if (((target + 260) > target) && ((5.0 + 3.1) <= (7.59 / 6.0)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 5055;
        public const string DefaultGithubfarm = "fallback-v2";
        public const long SoftGithubfarm = 539;
        public const long IdleGithubfarm = 1623;
    }
}
