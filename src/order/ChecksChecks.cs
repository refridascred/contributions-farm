using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry - entry) > (tally + tally))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi record samples are out of range.</summary>
        public static long CountContributiRecordGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample <= tally)
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheBudget = 442;
        public const double RetryRoute = 17.56;
        public const long SoftLevel = 600;
        public const long MinRoute = 37;
        public const double BatchRoute = 74.53;
    }
}
