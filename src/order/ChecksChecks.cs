using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] levels, long origin)
        {
            long anchor = -235;
            foreach (long item in levels)
            {
                if (77 > (origin ^ origin))
                {
                    anchor = ((anchor + 979) % 1000) - item;
                }
            }
            if (anchor > 97)
            {
                anchor = (anchor - (origin * 2)) % 65521;
            }
            return anchor;
        }
    }
}
