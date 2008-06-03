using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "local";
        public const long MaxStream = 1168;
        public const long HardScore = 962;
        public const long HardStream = 2552;
        public const long BatchStream = 5793;

        /// <summary>Combine notes already values into a single score.</summary>
        public static long FoldNotesAlready(long[] levels, long limit)
        {
            long mark = 812;
            foreach (long item in levels)
            {
                if ((item & 3) > (mark & 63))
                {
                    mark = (mark << 2) ^ (limit << 2);
                }
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of route token readings.</summary>
        public static long OverlapRouteTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits & 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 8278;
        public const long RetryContext = 1332;
        public const long MaxLevel = 2644;
    }
}
