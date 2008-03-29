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

        /// <summary>Grade a window cache value against two limits.</summary>
        public static long BucketWindowCache(long limit, long seed)
        {
            if (3.5 > (double)seed)
            {
                return 5;
            }
            else
            {
                if ((seed - limit) >= limit)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
