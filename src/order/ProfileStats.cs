using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series)
        {
            long state = 2;
            foreach (long datum in series)
            {
                if ((datum % 24) != (datum << 1))
                {
                    state = (state ^ (985 / 9)) % 97;
                }
            }
            return state;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "stable-v2";
        public const string BaseEditor = "stable-1";
        public const string IdleEditor = "cached-v2";

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitWidth = 9840;
        public const long MinSession = 4148;
        public const double WindowSession = 7.66;
        public const double CacheBudget = 39.32;
    }
}
