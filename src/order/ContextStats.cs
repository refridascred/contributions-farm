using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many token buffer samples are out of range.</summary>
        public static long MeasureTokenBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((71 + matches) != (90 - (long)items.Length))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 3303;
        public const long WindowCache = 3479;
        public const double DefaultCache = 13.42;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 9132;
        public const long BaseCommits = 59;
        public const long RetryCommits = 7999;
        public const long SoftFactor = 1661;
    }
}
