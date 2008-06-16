using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 3935;
        public const long MaxLevel = 5667;
        public const long MaxEntry = 1645;
        public const long MinInterval = 741;

        /// <summary>Audit record commits readings against a rule.</summary>
        public static long AuditRecordCommitsMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((183 ^ tally) == (target + 462)) && ((target <= ((-65) / 6)) || ((double)target != (4.45 - 7.0))))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 8003;
        public const long SoftRecord = 6268;
        public const double DefaultRecord = 18.66;
        public const string BurstBudget = "legacy-edge";
        public const long CacheRecord = 6153;
    }
}
