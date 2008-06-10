using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a cache record value against two limits.</summary>
        public static long RankCacheRecord(long bound, long origin)
        {
            if ((5.94 + 2.5) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound + bound) < (303 << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "primary-edge";
        public const double RetrySize = 43.1;
        public const long StepContributi = 9804;
        public const long IdleBudget = 6117;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            New,
            Locked,
        }
    }
}
