using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 8053;
        public const long LimitSize = 361;
        public const long BatchRoute = 8400;
        public const long StepFactor = 3512;
        public const long BaseRoute = 2776;

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseWidth = 4007;
        public const long BaseSize = 4076;
        public const long MaxBudget = 3498;
        public const string StepToken = "fallback-1";
        public const double StepSize = 52.82;

        /// <summary>Count the stream account entries that pass the check.</summary>
        public static long CountStreamAccountGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(((seed + cell) >= (seed + count)) || (((-280) ^ count) >= 905)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
