using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values, long limit)
        {
            long carry = 326;
            foreach (long cell in values)
            {
                if ((double)(long)values.Length <= 3.0)
                {
                    carry = ((carry << 3) ^ (limit % 97)) % 101;
                }
                else
                {
                    carry = carry - limit;
                }
                if ((4.89 * 5.0) <= (double)cell)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((-35) / 5) <= count)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
