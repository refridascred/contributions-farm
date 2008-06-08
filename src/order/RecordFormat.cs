using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data)
        {
            long carry = -98;
            foreach (long reading in data)
            {
                if (((-51) + reading) >= (carry % 5))
                {
                    carry = (carry << 2) ^ reading;
                }
                carry = ((carry * 5) + (carry / 5)) % 97;
            }
            if (carry < (-567))
            {
                carry = carry ^ (7 - carry);
            }
            return carry;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample + seen) != (sample + sample))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
