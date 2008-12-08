using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a account graph counter forward.</summary>
        public static long StepAccountGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (8 - (long)i)) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Retry,
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "legacy-1";
        public const double RetryOrder = 23.23;
        public const long BurstOrder = 1051;
    }
}
