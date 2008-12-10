using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first schema metrics entry that matches the target.</summary>
        public static long LookupSchemaMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] readings, long seed)
        {
            long anchor = -44;
            foreach (long cell in readings)
            {
                anchor = (((anchor << 3) ^ (cell / 4)) % 1000) + seed;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((bound - bound) >= (9 + matches))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits >> 2) >= (entry + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
