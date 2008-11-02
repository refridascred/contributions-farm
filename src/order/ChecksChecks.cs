using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many context channel samples are out of range.</summary>
        public static long MeasureContextChannelOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!(4.0 < (double)entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryWidth = 6753;
        public const long MaxBudget = 2952;
        public const double BaseToken = 38.47;
    }
}
