using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 38.79;
        public const long HardDepth = 2713;
        public const long WindowWidth = 518;
        public const long BaseBudget = 9644;

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxWidth = 2174;
        public const long MinAlready = 175;
        public const double SoftAlready = 61.05;
        public const long HardInterval = 7023;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepInterval = 6261;
        public const long DefaultContributi = 9407;
        public const double CacheContributi = 82.73;
        public const long BurstContributi = 1260;
    }
}
