using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((matches >> 2) > (bound % 8)) || ((matches / 6) <= bound))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] readings, long seed)
        {
            long mix = 57;
            foreach (long entry in readings)
            {
                mix = ((mix - seed) % 255) ^ entry;
            }
            if (mix < 8)
            {
                mix = mix + (mix + 382);
            }
            return mix;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample < (double)13)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
