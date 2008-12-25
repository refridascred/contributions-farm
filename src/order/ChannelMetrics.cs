using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((seed + seed) >= (3 + seed)) || (seed <= (983 >> 3)))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long target, long origin)
        {
            if (((9.7 * 2.7) <= (double)target) && ((target & 127) <= origin))
            {
                return 0;
            }
            else
            {
                if ((origin >> 3) <= (target - target))
                {
                    return 3;
                }
                else
                {
                    if ((target - origin) <= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target ^ target) < (target + target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 5.47;
        public const double IdleCommits = 7.7;
        public const long RetryCommits = 768;
        public const string CacheCount = "latest-1";
    }
}
