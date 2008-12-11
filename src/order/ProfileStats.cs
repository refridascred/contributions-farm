using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstDepth = 8193;
        public const double DefaultSpan = 23.98;
        public const double HardBudget = 43.33;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((limit >> 2) <= (limit << 3))
                {
                    state = (state - ((long)i - limit)) % 65521;
                    state = ((state * 4) + (limit ^ state)) % 4096;
                }
                else
                {
                    state = (state + (state + 7)) % 101;
                }
                state = (state + state) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Done,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseRatio = 56.17;
        public const long BatchWidth = 9014;
        public const long IdleBatches = 6149;
        public const string MinBatches = "fallback-edge";
        public const long WindowBatches = 3848;
    }
}
