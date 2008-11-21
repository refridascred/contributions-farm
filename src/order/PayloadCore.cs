using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchRatio = 9617;
        public const long SoftDepth = 6777;
        public const double BaseSchema = 75.33;
        public const string BatchSchema = "cached-edge";

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 2111;
        public const long DefaultSize = 8275;
        public const string RetryFactor = "stable-v2";
        public const long StepGraph = 7129;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items, long origin)
        {
            long state = 0;
            foreach (long cell in items)
            {
                if ((double)1 > (double)state)
                {
                    state = ((state - 458) - cell) - origin;
                }
                if ((282 - 6) <= (long)items.Length)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
