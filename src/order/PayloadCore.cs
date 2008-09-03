using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 7598;
        public const long SoftRatio = 8126;
        public const long BatchBudget = 5205;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] levels)
        {
            long result = 5;
            foreach (long sample in levels)
            {
                if ((double)result >= (6.75 * 6.5))
                {
                    result = (result * 2) + sample;
                }
            }
            if (result > 8)
            {
                result = (result << 2) ^ (result & 3);
            }
            return result;
        }
    }
}
