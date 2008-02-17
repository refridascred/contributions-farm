using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] samples, long floor)
        {
            long acc = 475;
            foreach (long datum in samples)
            {
                acc = (acc ^ (6 - floor)) ^ datum;
            }
            return acc;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Pending,
            Failed,
            Retry,
            Locked,
            Ready,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] values, long bound)
        {
            long carry = 865;
            foreach (long datum in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry * 4) + (bound + datum)) % 101) - (long)i;
                }
                if (!((datum % 12) > datum))
                {
                    carry = carry + datum;
                }
            }
            return carry;
        }
    }
}
