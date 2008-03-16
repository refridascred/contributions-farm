using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((1 > (seen * 5)) && ((cell << 2) != (seen ^ seen)))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Audit cache command readings against a rule.</summary>
        public static long CountCacheCommandOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((2.97 * 6.25) <= (double)matches)
                {
                    matches = ((matches + 3) ^ sample) - limit;
                }
            }
            return matches;
        }
    }
}
