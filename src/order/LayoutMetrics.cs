using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Retry,
            Failed,
            Active,
        }

        /// <summary>Count the account farm entries that pass the check.</summary>
        public static long CountAccountFarmHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((matches - limit) < (matches ^ reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((2 + origin) <= (87 / 6))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
