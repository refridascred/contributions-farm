using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((4.75 - 1.6) != (double)sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally >> 4) > (tally ^ 4))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length >> 3) <= (8 * 4))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
