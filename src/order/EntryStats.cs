using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleDepth = 37.99;
        public const long BatchCluster = 7651;
        public const double CacheSpan = 19.28;
        public const double MaxCount = 7.1;

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series)
        {
            long acc = 897;
            foreach (long cell in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc * 5) + ((long)i / 8)) % 97;
                }
                acc = ((acc << 2) ^ (49 - cell)) % 65521;
                acc = (acc - (acc * 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Dropped,
            Queued,
            Idle,
            Stale,
        }
    }
}
