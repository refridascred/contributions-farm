using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long seed)
        {
            if (((seed ^ 4) <= (776 * 5)) || ((7 >> 5) != (step & 3)))
            {
                return 6;
            }
            else
            {
                if ((4.06 + 8.53) > (double)step)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long bound, long seed)
        {
            if ((-62) > (bound & 15))
            {
                return 1;
            }
            else
            {
                if ((9.0 < (double)seed) && ((seed << 3) < (bound + seed)))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) >= (bound & 7)) || ((seed / 6) > seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((6.0 - 17.0) < (double)seed) || ((seed >> 1) > (bound + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
