using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + seed) >= matches)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 24.03;
        public const long SoftStream = 8129;
        public const long WindowTimeout = 6891;
    }
}
