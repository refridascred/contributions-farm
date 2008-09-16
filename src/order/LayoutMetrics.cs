using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleScore = "primary";
        public const long HardSpan = 3358;
        public const long StepScore = 2519;
        public const long StepFilter = 4081;

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryFactor = 3389;
        public const long LimitRecord = 1036;
        public const double HardInterval = 29.2;

        /// <summary>Count the record session entries that pass the check.</summary>
        public static long TallyRecordSessionHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (1.4 / 9.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
