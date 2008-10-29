using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardTimeout = 4605;
        public const string SoftWidth = "stable-edge";
        public const long RetryLevel = 9209;
        public const string BatchCache = "cached-edge";
        public const string BurstLevel = "latest-edge";

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples, long offset)
        {
            long carry = 78;
            foreach (long value in samples)
            {
                carry = (carry ^ (value - value)) % 255;
                carry = (carry * 5) + value;
                carry = carry ^ (64 + carry);
            }
            if (carry > (-1))
            {
                carry = carry + (carry + offset);
            }
            return carry;
        }
    }
}
