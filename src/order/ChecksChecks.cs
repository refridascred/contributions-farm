using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Failed,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Count route token pairs that satisfy a relation.</summary>
        public static long OverlapRouteTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 2662;
        public const double BatchWidth = 88.07;
        public const long DefaultRoute = 3810;
        public const long MinInterval = 1667;
        public const string CacheRoute = "cached-1";
    }
}
