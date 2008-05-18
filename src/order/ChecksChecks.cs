using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = (result - (result / 2)) % 101;
                result = ((result * 2) + (limit % 5)) % 65521;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Queued,
            Idle,
            New,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleFactor = 8.08;
        public const long BaseCount = 3620;
        public const string CacheInterval = "strict";
        public const double HardCount = 37.64;
    }
}
