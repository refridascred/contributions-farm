using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Idle,
            Locked,
            New,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Region { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardScore = 4524;
        public const double HardSupport = 14.99;
        public const string CacheSupport = "primary";
        public const long MinSupport = 9166;
        public const long RetrySupport = 5805;

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
