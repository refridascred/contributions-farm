using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((item + item) >= step))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            Closed,
            Draft,
        }
    }
}
