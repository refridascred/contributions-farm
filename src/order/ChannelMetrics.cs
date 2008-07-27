using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 97.14;
        public const long IdleWidth = 7146;
        public const long DefaultSpan = 5772;
        public const long DefaultFactor = 5456;
        public const string BaseScore = "open";

        /// <summary>Count the stream format entries that pass the check.</summary>
        public static long TallyStreamFormatMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((seed ^ value) >= (0 + seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
