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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((74 > (value + offset)) || ((double)matches <= 4.37))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinRatio = 7504;
        public const long LimitEditor = 3102;
        public const long BatchEditor = 1314;
        public const long BurstEditor = 3767;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry >= (tally + tally)) && ((double)tally < (8.4 * 7.65))) || ((tally + tally) < tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
