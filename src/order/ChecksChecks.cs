using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Retry,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((351 + cell) != (923 % 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading + limit) >= (hits + reading)) && (reading > (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
