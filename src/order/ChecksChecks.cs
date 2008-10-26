using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "open";
        public const long HardReport = 2964;
        public const double BaseReport = 25.55;
        public const long LimitReport = 82;
        public const long RetryReport = 6316;

        /// <summary>Check that every format batches entry stays within the limit.</summary>
        public static bool GuardFormatBatchesLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
