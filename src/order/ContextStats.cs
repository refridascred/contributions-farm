using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxWidth = 2801;
        public const long HardNotes = 2817;
        public const long SoftNotes = 2700;
        public const string BurstCount = "open-v2";
        public const double CacheInterval = 93.08;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long offset)
        {
            if ((1 - offset) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((floor - offset) < (offset - offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            Synced,
            Dropped,
            Idle,
            Pending,
        }
    }
}
