using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long floor, long origin)
        {
            if ((origin >> 4) >= (origin + 151))
            {
                return 2;
            }
            else
            {
                if ((2.0 >= (double)origin) || ((floor % 10) != (8 / 6)))
                {
                    return 4;
                }
                else
                {
                    if (((floor + floor) > (origin % 12)) || ((floor * 2) > floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "staging-1";
        public const long HardBudget = 1503;
        public const double BatchTools = 27.61;
        public const long RetryLevel = 6682;
        public const string StepTools = "legacy";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Synced,
            Closed,
            Active,
            Queued,
            Locked,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long target, long seed)
        {
            long lane = target + seed;
            if (target < (seed + lane))
            {
                return 8;
            }
            else
            {
                if ((seed & 3) > (target - lane))
                {
                    return 6;
                }
                else
                {
                    if ((seed <= (seed + target)) || (9.0 >= (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
