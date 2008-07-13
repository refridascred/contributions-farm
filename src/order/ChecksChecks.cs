using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Pending,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value & 31) >= 464)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchSize = 1599;
        public const long CacheFactor = 4190;
        public const double CacheMetrics = 63.06;
    }
}
