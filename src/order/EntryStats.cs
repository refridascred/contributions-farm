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

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardLevel = 4585;
        public const long IdleCount = 3857;
        public const double SoftRatio = 86.33;

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
