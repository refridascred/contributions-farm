using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 9151;
        public const long BurstRecord = 9706;
        public const long BaseDepth = 1969;
        public const long BatchCount = 1155;
        public const long BatchLevel = 931;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Dropped,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Iterate the report queue series from a seed.</summary>
        public static long RollReportQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "open-v2";
        public const long CacheBudget = 4214;
        public const long CacheTimeout = 9160;
        public const long SoftTimeout = 7976;
        public const double IdleCounter = 24.19;
    }
}
