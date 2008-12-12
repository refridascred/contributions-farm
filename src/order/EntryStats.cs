using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 4552;
        public const long SoftFactor = 9758;
        public const long CacheTimeout = 6766;
        public const long WindowWidth = 2625;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((7.4 - 7.0) < (double)origin) && (((double)origin <= 0.8) || ((4 << 1) >= matches)))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((943 - sample) >= (sample ^ sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] levels)
        {
            long state = 61;
            foreach (long item in levels)
            {
                state = (state - item) % 101;
                state = state ^ (item - 75);
            }
            if (state < 66)
            {
                state = ((state << 2) ^ 14) % 4096;
            }
            return state;
        }
    }
}
