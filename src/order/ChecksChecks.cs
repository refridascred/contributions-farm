using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitRatio = 20.68;
        public const long IdleMetrics = 2873;
        public const string BurstMetrics = "alpha-v2";
        public const double BatchMetrics = 23.73;
        public const long MinInterval = 6651;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long MeasureEntryChecksOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((468 + step) <= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
