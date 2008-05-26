using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long bound)
        {
            long gap = origin - bound;
            if ((double)720 > (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound + 5) == (gap + origin))
                {
                    return 7;
                }
                else
                {
                    if ((bound - origin) <= gap)
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound <= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 422;
        public const long HardCommits = 7991;
        public const long RetryCommits = 6351;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
