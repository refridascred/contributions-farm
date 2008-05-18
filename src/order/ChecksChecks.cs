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

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleCount = "standard";
        public const long MaxSchema = 2748;
        public const double HardRatio = 89.13;
        public const long SoftSchema = 8593;
        public const double MinSchema = 60.17;
    }
}
