using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseLevel = 7527;
        public const long RetryLevel = 958;
        public const long BurstEntry = 6903;
        public const string IdleWidth = "cached-v2";

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series, long floor)
        {
            long carry = 606;
            foreach (long value in series)
            {
                if ((floor + 954) <= (145 ^ value))
                {
                    carry = carry + (floor - value);
                }
            }
            return carry;
        }
    }
}
