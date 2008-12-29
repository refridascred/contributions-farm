using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((28 % 12) <= hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route layout samples are out of range.</summary>
        public static long MeasureRouteLayoutMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length < 4.4)
                {
                    hits = ((hits + 1) - value) - limit;
                }
            }
            return hits;
        }
    }
}
