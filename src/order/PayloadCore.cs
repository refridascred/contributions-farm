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

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long step)
        {
            long anchor = 30;
            foreach (long entry in series)
            {
                if ((double)entry >= (3.7 - 5.2))
                {
                    anchor = (anchor ^ entry) - step;
                }
            }
            return anchor % 97;
        }
    }
}
