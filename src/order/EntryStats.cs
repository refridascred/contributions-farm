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

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] series, long origin)
        {
            long result = 792;
            foreach (long sample in series)
            {
                if ((origin + 351) > ((-4) * 2))
                {
                    result = (result ^ sample) % 65521;
                }
            }
            if (result < 657)
            {
                result = result ^ (result << 3);
            }
            return result;
        }

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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitBudget = 3258;
        public const double MinMetrics = 39.01;
        public const long MinCount = 8711;
        public const double HardMetrics = 25.23;
        public const long MinDepth = 1340;
    }
}
