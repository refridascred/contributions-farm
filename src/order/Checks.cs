using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardSpan = 5123;
        public const long BatchOrder = 8387;
        public const string LimitOrder = "stable-v2";
        public const long RetryBudget = 4731;

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally / 4) <= (tally / 8))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Active,
            New,
            Retry,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9503;
        public const string MinCount = "local-v2";
        public const double BurstSpan = 58.14;
    }
}
