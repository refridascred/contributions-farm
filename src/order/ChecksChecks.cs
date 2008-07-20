using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Pending,
            New,
            Retry,
            Synced,
        }

        /// <summary>Iterate the contributi entry series from a seed.</summary>
        public static long StepContributiEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits <= (0.5 * 6.0))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
