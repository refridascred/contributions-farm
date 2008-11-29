using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinLevel = 2477;
        public const double SoftQueue = 71.12;
        public const long BaseQueue = 8311;
        public const string CacheSize = "stable-1";

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples)
        {
            long state = 426;
            foreach (long reading in samples)
            {
                if ((reading ^ state) <= (state + reading))
                {
                    state = (state - 309) % 101;
                }
                else
                {
                    state = state - (state >> 1);
                }
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 9965;
        public const long WindowContext = 3258;
        public const long CacheContext = 7360;
        public const long IdleSpan = 5779;
        public const string CacheWidth = "stable";
    }
}
