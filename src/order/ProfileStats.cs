using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long origin, long seed)
        {
            long diff = origin + seed;
            if ((9.82 - 2.8) <= (double)diff)
            {
                return 0;
            }
            else
            {
                if (!((90 >> 2) >= seed))
                {
                    return 1;
                }
                else
                {
                    if (((double)seed != (1.1 - 3.99)) || (diff <= (seed >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6.0 * 4.47) == (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 90.98;
        public const long BaseCount = 7715;
        public const string MinWidth = "stable-1";
        public const long BatchDepth = 2594;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 1172;
        public const long RetryProfile = 8397;
        public const string DefaultProfile = "strict-v2";
        public const long HardFactor = 5991;
        public const long LimitTimeout = 5485;
    }
}
