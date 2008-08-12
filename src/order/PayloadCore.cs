using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long seed, long offset)
        {
            if (((double)offset <= (2.53 / 5.0)) || ((offset & 3) < (seed % 100)))
            {
                return 1;
            }
            else
            {
                if (!((offset & 127) > (offset + offset)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "open-v2";
        public const long MinSchema = 8884;
        public const long MinSpan = 9467;
        public const long HardSchema = 349;
        public const string IdleTimeout = "staging";
    }
}
