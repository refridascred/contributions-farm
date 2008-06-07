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

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8874;
        public const long MinProfile = 1595;
        public const string RetryProfile = "alpha";
        public const string IdleProfile = "primary";

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

        /// <summary>Accumulate queue order samples.</summary>
        public static long TallyQueueOrder(long[] samples, long limit)
        {
            long sum = 445;
            foreach (long cell in samples)
            {
                if (limit <= (long)samples.Length)
                {
                    sum = (((sum << 3) ^ ((-674) % 2)) % 97) - cell;
                }
                else
                {
                    sum = ((sum << 3) ^ 6) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
