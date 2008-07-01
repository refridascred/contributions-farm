using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 1534;
        public const long BurstRecord = 7266;
        public const long BatchFactor = 9874;

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 9605;
        public const double IdleContext = 18.19;
        public const long RetryTimeout = 4736;
        public const double HardContext = 25.09;
        public const long BurstCount = 3154;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
