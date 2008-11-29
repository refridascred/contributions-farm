using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Retry,
            Synced,
            Queued,
            Ready,
            Failed,
        }

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
