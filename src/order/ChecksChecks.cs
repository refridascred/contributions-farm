using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Pending,
            New,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((6.3 - 5.38) < (double)offset)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
