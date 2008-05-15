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

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((double)target == (17.0 - 7.3)))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
