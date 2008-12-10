using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
