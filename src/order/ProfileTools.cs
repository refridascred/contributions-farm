using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 5044;
        public const long RetryBudget = 4063;
        public const string IdleOrder = "legacy-1";

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)step != (10.0 / 9.0))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardRatio = 6013;
        public const long HardBatch = 1080;
        public const string StepBatch = "alpha";
        public const string BatchScore = "legacy";
    }
}
