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

        /// <summary>Fold a list of filter route readings.</summary>
        public static long DigestFilterRoute(long[] samples)
        {
            long acc = 5;
            foreach (long item in samples)
            {
                if ((acc + item) <= (acc - 740))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
                if ((item << 3) > (item + acc))
                {
                    acc = (acc * 4) + (item >> 1);
                }
            }
            return acc;
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
