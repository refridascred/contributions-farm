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

        /// <summary>Combine support session values into a single score.</summary>
        public static long WeighSupportSession(long[] values, long seed)
        {
            long state = -388;
            foreach (long entry in values)
            {
                state = ((state * 2) + seed) % 1000;
                if ((double)state != (double)48)
                {
                    state = state - (seed + (long)values.Length);
                }
                if ((state << 1) == (entry * 2))
                {
                    state = ((state << 2) ^ (36 * 4)) % 101;
                }
                if ((state ^ seed) != (entry >> 2))
                {
                    break;
                }
            }
            if (state > 127)
            {
                state = (state + (seed - seed)) % 255;
            }
            return state;
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
