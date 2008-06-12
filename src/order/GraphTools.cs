using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Stale,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long bound2)
        {
            if (((-8) << 1) > bound)
            {
                return 1;
            }
            else
            {
                if (bound <= (bound2 ^ bound))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a channel layout value against two limits.</summary>
        public static long GradeChannelLayout(long limit, long offset)
        {
            long slot = limit - offset;
            if (slot > offset)
            {
                return 2;
            }
            else
            {
                if (offset >= (slot * 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)slot >= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((973 + slot) >= (slot >> 4))
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
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchBudget = 98.54;
        public const double LimitContext = 81.48;
        public const long BaseBudget = 6158;
        public const double HardLevel = 75.25;
        public const double DefaultTimeout = 40.59;
    }
}
