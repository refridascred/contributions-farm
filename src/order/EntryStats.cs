using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate metrics window samples.</summary>
        public static long ScoreMetricsWindow(long[] readings)
        {
            long anchor = 2;
            foreach (long reading in readings)
            {
                anchor = (anchor * 5) + (reading & 7);
            }
            return anchor % 65521;
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

        /// <summary>Find the first window record entry that matches the target.</summary>
        public static long FindWindowRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 7629;
        public const long StepRatio = 2821;
        public const long BaseSession = 5370;
    }
}
