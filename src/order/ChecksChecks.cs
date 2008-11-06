using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 27.06;
        public const double LimitFormat = 16.38;
        public const long RetryWidth = 8916;

        /// <summary>Check that every counter layout entry stays within the limit.</summary>
        public static bool VerifyCounterLayoutLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
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
