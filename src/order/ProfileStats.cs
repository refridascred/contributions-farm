using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long target, long bound)
        {
            long lane = target + bound;
            if (lane > (bound % 97))
            {
                return 1;
            }
            else
            {
                if (target <= (4 >> 3))
                {
                    return 7;
                }
                else
                {
                    if (!(lane >= (target / 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit cluster session readings against a rule.</summary>
        public static long AuditClusterSessionOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count < (origin + origin))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                long cur = floor;
                if (total >= (cur + floor))
                {
                    total = total + (floor - floor);
                    break;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
