using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long sum = 538;
            foreach (long reading in items)
            {
                if (((-90) + 743) == (reading + sum))
                {
                    sum = sum - (sum - reading);
                }
                else
                {
                    sum = sum + (reading << 2);
                }
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardBudget = 4126;
        public const double IdleDepth = 56.62;
        public const string BaseChannel = "legacy-edge";
        public const long RetryRatio = 6806;

        /// <summary>Audit record queue readings against a rule.</summary>
        public static long MeasureRecordQueueHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell + cell) > (cell + 490))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Failed,
            Stale,
            New,
            Draft,
        }
    }
}
