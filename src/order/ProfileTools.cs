using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series, long origin)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                if ((origin + origin) <= (carry / 7))
                {
                    carry = (carry - (origin + origin)) % 1000;
                }
                else
                {
                    carry = (carry - (carry ^ entry)) % 255;
                }
            }
            if (carry > (-5))
            {
                carry = carry ^ (origin % 2);
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 1242;
        public const string SoftDepth = "legacy";
        public const string IdleMetric = "fallback-1";
        public const long MaxMetric = 1587;
        public const double BurstMetric = 29.18;

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinRatio = 7504;
        public const long LimitEditor = 3102;
        public const long BatchEditor = 1314;
        public const long BurstEditor = 3767;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!(((offset / 8) <= (8 & 127)) || ((offset - (long)items.Length) <= (item - 186))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor entry entry stays within the limit.</summary>
        public static bool CheckEditorEntryLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
