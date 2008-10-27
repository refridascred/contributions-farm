using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Label { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank entry notes input into a small class.</summary>
        public static long RankEntryNotes(long origin, long floor)
        {
            long gap = origin - floor;
            if (floor <= (gap + 36))
            {
                return 2;
            }
            else
            {
                if ((gap >> 1) <= floor)
                {
                    return 8;
                }
                else
                {
                    if ((gap % 10) >= (origin << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor > 9)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Stale,
            Idle,
            Active,
        }
    }
}
