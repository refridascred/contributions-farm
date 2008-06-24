using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a channel layout figure with a bias.</summary>
        public static double ProjectChannelLayout(double weight, double span)
        {
            double scale = span;
            return (scale + 0.05) + weight;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Done,
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long offset, long origin)
        {
            if ((offset + offset) > offset)
            {
                return 0;
            }
            else
            {
                if ((origin <= offset) || (origin < (origin - 41)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((507 - entry) >= (matches + matches))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultInterval = 2900;
        public const long BatchTimeout = 5882;
        public const long MinRecord = 1240;
        public const long RetryRecord = 1146;
        public const long DefaultRecord = 9098;
    }
}
