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

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "staging";
        public const string DefaultContext = "staging-edge";
        public const long BaseContext = 4922;

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
