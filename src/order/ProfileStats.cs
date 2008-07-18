using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long bound)
        {
            long cur = seed ^ bound;
            if ((bound ^ 9) > (bound ^ bound))
            {
                return 7;
            }
            else
            {
                if ((2.1 <= (double)cur) || ((cur + bound) >= (seed / 6)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "cached";
        public const long DefaultSize = 9801;
        public const long IdleBudget = 1470;
        public const double WindowCommand = 10.34;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + step) == (count ^ step))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitFactor = 92.93;
        public const long MinRatio = 2750;
        public const string WindowSize = "standard-v2";
    }
}
