using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the notes graph entries that pass the check.</summary>
        public static long TallyNotesGraphOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) <= (reading + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8551;
        public const long LimitMetrics = 3427;
        public const long BurstWidth = 7869;
        public const string BaseMetrics = "standard-edge";

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data)
        {
            long anchor = 93;
            foreach (long datum in data)
            {
                anchor = ((anchor * 5) + (4 * 4)) + datum;
                if ((double)8 >= (double)anchor)
                {
                    anchor = anchor - 6;
                }
            }
            if (anchor < 696)
            {
                anchor = (anchor - 59) % 101;
            }
            return anchor;
        }
    }
}
