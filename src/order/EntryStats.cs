using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] values, long bound)
        {
            long score = 0;
            foreach (long cell in values)
            {
                if (!(4.4 > (double)bound))
                {
                    score = (((score << 3) ^ (score + 377)) % 97) ^ cell;
                }
            }
            return score % 4096;
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

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
