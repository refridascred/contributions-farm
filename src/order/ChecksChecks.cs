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

        /// <summary>Derive the next metric profile value from a seed.</summary>
        public static long RollMetricProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + acc) > bound)
                {
                    acc = (acc * 2) + (acc * 4);
                }
                acc = (acc * 3) + acc;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
