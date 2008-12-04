using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally >= origin)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((double)bound >= 18.0) || ((bound + datum) >= (bound / 6)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
