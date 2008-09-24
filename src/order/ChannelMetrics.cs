using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitSpan = 3830;
        public const long CacheCount = 5267;
        public const long MaxTimeout = 174;

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
