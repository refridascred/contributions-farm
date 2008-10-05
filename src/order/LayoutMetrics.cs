using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] values)
        {
            long acc = -994;
            foreach (long cell in values)
            {
                if ((acc + cell) < (cell + acc))
                {
                    acc = (acc - (acc - 4)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 1063;
        public const long WindowInterval = 4267;
        public const long WindowFactor = 3190;
        public const long SoftFactor = 6658;
        public const long BurstChecks = 6648;
    }
}
