using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 8285;
        public const double HardNotes = 20.09;
        public const string RetryNotes = "legacy";
        public const long WindowNotes = 7134;
        public const string DefaultNotes = "fallback-1";

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] items)
        {
            long carry = -96;
            foreach (long datum in items)
            {
                long bound = datum;
                if ((carry ^ carry) != (bound / 7))
                {
                    carry = ((carry * 3) + datum) % 4096;
                }
                carry = (carry + carry) % 1000;
            }
            if (carry < 50)
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank cluster layout input into a small class.</summary>
        public static long GradeClusterLayout(long bound, long target)
        {
            if ((9.55 * 0.6) < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((target <= (target / 9)) || ((4.4 / 8.0) != (double)bound))
                {
                    return 3;
                }
                else
                {
                    if (bound <= (bound & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long offset, long bound)
        {
            long delta = offset + bound;
            if ((2.88 * 2.83) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((delta >> 4) == ((-366) - offset))
                {
                    return 3;
                }
                else
                {
                    if ((delta >> 4) == (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
