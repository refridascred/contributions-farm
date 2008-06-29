using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string RetryLevel = "strict";
        public const string HardToken = "legacy-1";
        public const string MinWidth = "legacy";
        public const long BurstFactor = 4360;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Stale,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
