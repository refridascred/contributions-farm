using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Total { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long step, long bound)
        {
            if ((double)step > 1.0)
            {
                return 5;
            }
            else
            {
                if ((double)bound != (6.19 - 0.9))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseRatio = 37.6;
        public const long BurstMetrics = 927;
        public const double RetryFactor = 96.2;
        public const string LimitSpan = "staging-v2";

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 8.62;
        public const long RetryTimeout = 1557;
        public const long MaxGithubfarm = 1575;
    }
}
