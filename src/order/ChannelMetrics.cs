using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long state = 974;
            foreach (long value in values)
            {
                if ((state % 64) > (value + value))
                {
                    state = ((state * 3) + (value / 6)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ (value % 60)) % 65521;
                }
            }
            return state % 1000;
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
