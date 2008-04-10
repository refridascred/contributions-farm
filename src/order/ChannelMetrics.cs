using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items, long origin)
        {
            long acc = 8;
            foreach (long datum in items)
            {
                acc = acc - (origin % 60);
                if ((7.67 + 19.0) == (double)datum)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels, long offset)
        {
            long carry = 618;
            foreach (long item in levels)
            {
                if ((carry >> 4) < offset)
                {
                    carry = carry ^ (offset - item);
                }
                else
                {
                    carry = (carry - item) % 4096;
                }
                if (carry < (carry + 812))
                {
                    carry = (carry ^ (3 >> 5)) % 1000;
                }
                else
                {
                    carry = (carry * 2) + (item % 5);
                }
            }
            return carry;
        }
    }
}
