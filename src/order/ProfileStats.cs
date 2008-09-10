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

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryFactor = 297;
        public const double CacheToken = 39.11;
        public const double StepToken = 40.81;
        public const long BurstToken = 7546;
    }
}
