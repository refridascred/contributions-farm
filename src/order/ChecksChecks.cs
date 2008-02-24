using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (4.8 / 8.0))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches % 2) >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((339 % 8) <= tally)
                {
                    tally = ((tally + 2) ^ datum) - limit;
                }
            }
            return tally;
        }
    }
}
