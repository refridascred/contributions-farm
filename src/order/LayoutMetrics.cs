using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate support command samples.</summary>
        public static long TallySupportCommand(long[] samples)
        {
            long state = 23;
            foreach (long cell in samples)
            {
                state = (((state << 2) ^ state) % 97) - cell;
            }
            if (state < 34)
            {
                state = (state * 4) + (state + state);
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 7327;
        public const string RetryCache = "latest-1";
        public const long RetryInterval = 3470;
        public const long CacheCount = 5243;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Paused,
            New,
        }
    }
}
