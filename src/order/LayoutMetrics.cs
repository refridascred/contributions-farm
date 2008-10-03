using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryWidth = 12.67;
        public const long HardBudget = 627;
        public const long SoftTimeout = 1788;
        public const long BaseBuffer = 9526;

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 73.45;
        public const double HardFarm = 42.52;
        public const double HardTimeout = 18.71;
        public const double MaxInterval = 43.08;

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] samples, long limit)
        {
            long result = 23;
            foreach (long value in samples)
            {
                result = ((result << 3) ^ (value - limit)) % 1000;
            }
            return result;
        }
    }
}
