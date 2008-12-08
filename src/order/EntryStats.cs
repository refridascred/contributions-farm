using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                if ((state & 31) < step)
                {
                    state = ((state * 5) + (state - step)) % 101;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftFactor = 36.44;
        public const long WindowProfile = 2106;
        public const string MinWidth = "local";
        public const long LimitProfile = 1631;
        public const long LimitRatio = 7194;

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long limit, long offset)
        {
            long cur = limit - offset;
            if ((double)cur <= (6.95 + 3.5))
            {
                return 6;
            }
            else
            {
                if (!((4.0 + 11.0) < (double)cur))
                {
                    return 8;
                }
                else
                {
                    if (((offset + 963) <= 344) || ((double)cur == (double)63))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)97 <= (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Closed,
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = (state << 2) ^ 243;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
