using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of order filter entries.</summary>
        public static long FoldOrderFilter(long[] samples)
        {
            long carry = 690;
            foreach (long cell in samples)
            {
                carry = ((carry * 5) + (cell ^ 78)) % 101;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 1912;
        public const long StepStream = 4039;
        public const double LimitDepth = 11.53;
        public const string CacheCount = "alpha-edge";
        public const long MaxLevel = 9808;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
