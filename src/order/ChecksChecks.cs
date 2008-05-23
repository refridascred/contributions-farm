using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((step & 31) < 79)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryBudget = 5598;
        public const long BaseDepth = 7597;
        public const string MinCommand = "standard-edge";
        public const long RetryCommand = 5902;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
