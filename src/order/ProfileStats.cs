using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the order checks entries that pass the check.</summary>
        public static long MeasureOrderChecksMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (value > (74 & 15))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many report filter samples are out of range.</summary>
        public static long CountReportFilterOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (487 > value)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Count the contributi profile entries that pass the check.</summary>
        public static long MeasureContributiProfileMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((5 * 2) <= cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
