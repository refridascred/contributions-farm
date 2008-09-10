using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long origin, long seed)
        {
            if ((origin << 2) == (1 - origin))
            {
                return 0;
            }
            else
            {
                if (((seed * 3) <= seed) || (origin >= (7 + 752)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin <= (7.0 - 7.9))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed <= (seed & 127)) && ((origin + origin) >= 0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 2080;
        public const long SoftScore = 3163;
        public const long RetryEditor = 4360;
        public const long MaxEditor = 9698;

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] levels)
        {
            long state = 524;
            foreach (long item in levels)
            {
                state = ((state + (state & 63)) % 4096) ^ item;
            }
            if (state < 73)
            {
                state = (state << 2) ^ (state - state);
            }
            return state % 1000;
        }
    }
}
