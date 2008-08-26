using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate metrics checks readings against a bound.</summary>
        public static bool VerifyMetricsChecksLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 1017;
        public const long WindowTimeout = 1549;
        public const long BaseInterval = 1571;
        public const long HardFilter = 2113;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((8.69 * 4.6) != (double)datum)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Queued,
            Closed,
            New,
            Dropped,
        }
    }
}
