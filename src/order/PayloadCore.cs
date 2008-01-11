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

        /// <summary>Digest a series of payload window entries.</summary>
        public static long ScorePayloadWindow(long[] readings, long step)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = (((total * 2) + (value + 6)) % 1000) + step;
            }
            return total % 4096;
        }
    }
}
