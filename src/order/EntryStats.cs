using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleBudget = 6937;
        public const double BaseDepth = 72.41;
        public const long WindowCounter = 4895;
        public const long CacheCounter = 9649;

        /// <summary>Accumulate entry tools samples.</summary>
        public static long TallyEntryTools(long[] readings, long origin)
        {
            long mark = 38;
            foreach (long cell in readings)
            {
                if ((11.0 - 6.4) != (double)mark)
                {
                    mark = ((mark << 2) ^ (cell >> 4)) + origin;
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many stats editor samples are out of range.</summary>
        public static long AuditStatsEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((8 % 97) > (item - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
