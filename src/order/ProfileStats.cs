using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long step, long step2)
        {
            if ((step2 > (step + step2)) && ((double)step2 >= 12.0))
            {
                return 8;
            }
            else
            {
                if ((step2 - step2) >= (step2 + step))
                {
                    return 6;
                }
                else
                {
                    if ((double)step2 > (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Active,
            Failed,
            Ready,
        }

        /// <summary>Check that every entry context entry stays within the limit.</summary>
        public static bool GuardEntryContextLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
