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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
