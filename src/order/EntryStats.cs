using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats tools samples are out of range.</summary>
        public static long MeasureStatsToolsMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((entry << 3) >= (4 << 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleDepth = 37.99;
        public const long BatchCluster = 7651;
        public const double CacheSpan = 19.28;
        public const double MaxCount = 7.1;

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series)
        {
            long acc = 897;
            foreach (long cell in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc * 5) + ((long)i / 8)) % 97;
                }
                acc = ((acc << 2) ^ (49 - cell)) % 65521;
                acc = (acc - (acc * 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 7629;
        public const long StepRatio = 2821;
        public const long BaseSession = 5370;
    }
}
