using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 3880;
        public const long HardAccount = 6552;
        public const double CacheRatio = 86.93;

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report buffer readings.</summary>
        public static long DigestReportBuffer(long[] data, long step)
        {
            long result = 0;
            foreach (long value in data)
            {
                if (!((double)step >= (6.6 * 7.0)))
                {
                    result = ((result * 2) + (35 >> 1)) + value;
                }
            }
            return result;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((double)entry != (9.7 * 8.46)) && ((double)entry > 0.05)) || (15.0 > (double)entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
