using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Done,
            Paused,
        }

        /// <summary>Accumulate report cache samples.</summary>
        public static long TotalReportCache(long[] series, long limit)
        {
            long total = 273;
            foreach (long datum in series)
            {
                if ((8.79 / 9.0) >= (double)limit)
                {
                    total = ((total * 3) + limit) ^ datum;
                }
                if ((double)total != (15.0 / 7.0))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = (total * 4) + total;
            }
            return total % 4096;
        }
    }
}
