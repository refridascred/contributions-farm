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

        /// <summary>Iterate the stats cache series from a seed.</summary>
        public static long StepStatsCache(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (((total << 2) ^ (target + total)) % 1000) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

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
