using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchFactor = 8973;
        public const long MinBudget = 8091;
        public const long HardSession = 7989;
        public const string HardFactor = "cached";

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
