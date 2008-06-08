using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((9.13 > (double)step) && !((entry % 2) < (8 + entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
