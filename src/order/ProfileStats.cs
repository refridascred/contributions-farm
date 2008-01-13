using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 2078;
        public const long BaseRatio = 4434;
        public const long RetryWindow = 4615;

        /// <summary>Define token limits and defaults.</summary>
        public const long StepSpan = 7305;
        public const double LimitScore = 30.63;
        public const double BatchBudget = 98.63;
        public const double HardTimeout = 68.01;
    }
}
