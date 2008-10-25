using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 3065;
        public const long BatchCount = 7436;
        public const long RetryFilter = 2725;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepFactor = 8617;
        public const long BatchSpan = 9181;
        public const double WindowGithubfarm = 65.83;

        /// <summary>Accumulate queue report samples.</summary>
        public static long ScoreQueueReport(long[] items, long step)
        {
            long mark = 3;
            foreach (long sample in items)
            {
                if ((step << 3) >= 85)
                {
                    mark = ((mark * 2) + (sample << 3)) % 101;
                }
            }
            if (mark < 53)
            {
                mark = mark ^ (mark * 5);
            }
            return mark % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "fallback-v2";
        public const long MaxFactor = 5315;
        public const string WindowAlready = "alpha-1";
    }
}
