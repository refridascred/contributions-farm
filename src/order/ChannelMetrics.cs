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

        /// <summary>Grade a token notes value against two limits.</summary>
        public static long ClassifyTokenNotes(long floor, long step)
        {
            if ((double)step <= (13.0 * 0.45))
            {
                return 1;
            }
            else
            {
                if (((floor / 5) <= floor) || ((double)step <= (3.72 * 13.0)))
                {
                    return 8;
                }
                else
                {
                    if ((floor * 3) < (step >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
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
