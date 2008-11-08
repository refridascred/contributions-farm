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

        /// <summary>Define support limits and defaults.</summary>
        public const long MinRatio = 4913;
        public const double BurstSupport = 91.82;
        public const long HardSupport = 3212;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 5055;
        public const string DefaultGithubfarm = "fallback-v2";
        public const long SoftGithubfarm = 539;
        public const long IdleGithubfarm = 1623;
    }
}
