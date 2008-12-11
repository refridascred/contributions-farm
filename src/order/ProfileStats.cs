using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank session buffer input into a small class.</summary>
        public static long SortSessionBuffer(long bound, long seed)
        {
            if ((bound + bound) < bound)
            {
                return 6;
            }
            else
            {
                if ((bound > (bound << 1)) || (seed >= (bound + seed)))
                {
                    return 2;
                }
                else
                {
                    if ((5 + seed) <= (seed << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 61.68;
        public const long BurstSpan = 9293;
        public const long BatchRoute = 8249;
        public const long BaseFactor = 9458;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Done,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 8351;
        public const double LimitGraph = 49.63;
        public const double MinGraph = 17.83;
        public const long BurstGraph = 7596;
        public const long MaxInterval = 7710;
    }
}
