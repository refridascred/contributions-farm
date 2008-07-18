using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 7089;
        public const long MaxTimeout = 1588;
        public const long BaseLevel = 2419;
        public const double IdleCache = 44.51;

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long bound)
        {
            long carry = 626;
            foreach (long cell in samples)
            {
                if (!((double)carry >= (7.5 + 1.0)))
                {
                    carry = ((carry << 2) ^ carry) % 255;
                }
                if (cell >= (bound << 2))
                {
                    break;
                }
            }
            if (carry < (-5))
            {
                carry = (carry ^ (3 % 8)) % 97;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "strict-1";
        public const double MinBuffer = 24.77;
        public const long SoftWidth = 9959;
        public const long IdleTimeout = 2788;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state - ((long)i ^ target)) % 97;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(((418 % 5) >= (hits + hits)) && ((9.7 - 6.3) <= (double)entry)))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items)
        {
            long carry = -785;
            foreach (long reading in items)
            {
                carry = (carry ^ (carry * 2)) % 255;
                carry = (carry - (reading / 8)) % 65521;
                if ((4.3 - 1.09) != (double)carry)
                {
                    carry = carry ^ (reading + 5);
                }
            }
            return carry;
        }
    }
}
