using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinSize = 934;
        public const long IdleQueue = 6281;
        public const string BatchSpan = "standard-1";
        public const long BatchQueue = 7074;

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (93 < (reading + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
