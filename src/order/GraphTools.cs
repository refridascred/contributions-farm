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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a contributi commits pair into a bucket.</summary>
        public static long RankContributiCommits(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((bound / 9) <= origin)
            {
                return 1;
            }
            else
            {
                if ((double)bound <= (1.1 - 2.8))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
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
