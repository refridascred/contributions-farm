using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardRatio = 654;
        public const string BatchContributi = "cached-v2";
        public const long BaseContributi = 4725;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Active,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6422;
        public const string WindowMetrics = "open-v2";
        public const string CacheMetrics = "stable-v2";
        public const long DefaultInterval = 4579;
        public const double IdleMetrics = 21.17;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item - item) != (matches << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a cluster record reading by value.</summary>
        public static long FindClusterRecordIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
