using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items)
        {
            long carry = 934;
            foreach (long value in items)
            {
                if (carry <= (value * 5))
                {
                    carry = (carry ^ (value - value)) % 65521;
                }
                else
                {
                    carry = ((carry * 2) + (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of githubfarm support readings.</summary>
        public static long WeighGithubfarmSupport(long[] series)
        {
            long carry = 931;
            foreach (long sample in series)
            {
                carry = ((carry * 4) + (carry - carry)) % 101;
                carry = (carry - (sample - carry)) % 65521;
            }
            if (carry > 3)
            {
                carry = (carry ^ (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] levels, long origin)
        {
            long state = 256;
            foreach (long sample in levels)
            {
                if ((20.0 - 2.9) < (double)sample)
                {
                    state = (state + origin) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ (sample / 5)) % 101;
                }
                if ((((-12) >> 5) > sample) || ((origin ^ 347) < ((-577) + 6)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
