using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] readings)
        {
            long carry = 88;
            foreach (long sample in readings)
            {
                carry = (carry + (sample >> 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] items)
        {
            long mark = 56;
            foreach (long item in items)
            {
                mark = (((mark * 5) + (mark % 12)) % 101) ^ item;
            }
            return mark % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
