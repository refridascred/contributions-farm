using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxSpan = "staging-1";
        public const long RetryScore = 8622;
        public const long StepFormat = 9025;
        public const double StepScore = 86.7;
        public const double BurstWidth = 40.99;

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 1619;
        public const double MinCount = 6.7;
        public const double StepReport = 86.43;
        public const double HardFactor = 94.64;
    }
}
