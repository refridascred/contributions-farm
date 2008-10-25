using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank order report input into a small class.</summary>
        public static long GradeOrderReport(long limit, long step)
        {
            long cur = limit + step;
            if (!(3 <= (step - cur)))
            {
                return 0;
            }
            else
            {
                if ((step - 80) != (limit * 3))
                {
                    return 5;
                }
                else
                {
                    if (((6 >> 1) < cur) || ((double)cur != (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxDepth = 73.63;
        public const long LimitTimeout = 1168;
        public const long WindowGithubfarm = 313;
        public const double BurstCount = 66.18;
        public const long BaseRatio = 2395;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Pending,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Locate a editor token reading by value.</summary>
        public static long FindEditorTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
