using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((double)count == (9.64 - 8.0)) && ((6.3 + 9.8) != (double)count))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((sample >> 2) >= (limit & 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFactor = 41.91;
        public const double MinFilter = 26.59;
        public const string SoftInterval = "standard-1";
        public const string LimitLevel = "staging";
        public const long SoftFilter = 4307;
    }
}
