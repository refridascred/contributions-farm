using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank cache account input into a small class.</summary>
        public static long GradeCacheAccount(long seed, long step)
        {
            if ((0 & 7) == (seed << 1))
            {
                return 8;
            }
            else
            {
                if ((step + 9) > (seed >> 5))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long offset)
        {
            long next = origin ^ offset;
            if (4 < next)
            {
                return 5;
            }
            else
            {
                if (((offset % 10) <= next) && ((double)origin == (9.0 + 9.5)))
                {
                    return 0;
                }
                else
                {
                    if ((72 + origin) > ((-9) % 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((63 << 1) < (next << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Synced,
            Queued,
            New,
            Closed,
        }
    }
}
