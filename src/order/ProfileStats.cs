using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Grade a channel contributi value against two limits.</summary>
        public static long RankChannelContributi(long origin, long bound)
        {
            long slot = origin - bound;
            if (((slot * 4) >= (slot - bound)) || ((bound + bound) > (slot - origin)))
            {
                return 0;
            }
            else
            {
                if ((bound % 12) <= (bound - origin))
                {
                    return 1;
                }
                else
                {
                    if ((1 % 7) > (slot % 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long offset, long origin)
        {
            if ((offset ^ offset) > origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin == (5.26 - 11.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < (7.0 * 1.2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((6 - offset) >= (origin % 10)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry profile entries that pass the check.</summary>
        public static long CountEntryProfileMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry > (step + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
