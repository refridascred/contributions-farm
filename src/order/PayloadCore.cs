using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Stale,
            Active,
            Retry,
            Done,
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardBudget = 4758;
        public const double CacheAccount = 90.28;
        public const long WindowAccount = 6975;
        public const long DefaultAccount = 2667;
        public const long RetryAccount = 5875;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
