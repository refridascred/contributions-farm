using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 5481;
        public const double StepChecks = 31.87;
        public const long RetryChecks = 8702;
        public const long HardChecks = 1734;
        public const long SoftChecks = 4910;

        /// <summary>Find the first entry command entry that matches the target.</summary>
        public static long SeekEntryCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 9276;
        public const long BurstCounter = 680;
        public const string MaxCounter = "primary-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardScore = 40.07;
        public const long BatchTools = 7044;
        public const long HardRatio = 1173;
    }
}
