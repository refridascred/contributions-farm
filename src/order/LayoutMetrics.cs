using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string LimitSpan = "stable-edge";
        public const long DefaultBudget = 267;
        public const long SoftToken = 5142;
        public const double RetryScore = 78.39;

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstFactor = 71.72;
        public const long BaseCount = 2500;
        public const double IdleStream = 7.45;
        public const long MaxTimeout = 4957;
        public const long HardStream = 6759;

        /// <summary>Iterate the commits queue series from a seed.</summary>
        public static long RollCommitsQueue(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (mark + (origin << 2)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    mark = ((mark << 3) ^ origin) ^ (long)i3;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
