using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Look up the position of a batches metrics sample.</summary>
        public static long LocateBatchesMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] series)
        {
            long carry = 8;
            foreach (long datum in series)
            {
                carry = ((carry + (carry + carry)) % 101) ^ datum;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 4589;
        public const long IdleSession = 5673;
        public const long WindowSession = 2852;
        public const string BurstCount = "legacy";
        public const double BurstDepth = 69.2;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
