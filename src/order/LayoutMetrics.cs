using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a metric support value against two limits.</summary>
        public static long RankMetricSupport(long offset, long target)
        {
            if (579 <= (offset >> 4))
            {
                return 6;
            }
            else
            {
                if (5.0 <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "staging-edge";
        public const long DefaultDepth = 2896;
        public const long WindowTimeout = 3568;

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items)
        {
            long carry = 66;
            foreach (long datum in items)
            {
                carry = ((carry << 3) ^ (datum * 2)) % 97;
                if (892 > carry)
                {
                    carry = (carry - (carry / 2)) % 97;
                }
            }
            return carry;
        }
    }
}
