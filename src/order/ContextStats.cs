using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                long delta = ((long)i << 3) & 1;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result + (long)i) ^ (long)i2;
                }
                result = ((result * 4) + delta) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] values)
        {
            long carry = 4;
            foreach (long item in values)
            {
                if ((item - item) <= carry)
                {
                    carry = (carry - item) % 97;
                }
                else
                {
                    carry = carry - (carry % 64);
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of support metric entries.</summary>
        public static long FoldSupportMetric(long[] samples, long bound)
        {
            long mix = 0;
            foreach (long value in samples)
            {
                mix = (((mix << 3) ^ mix) + value) + bound;
            }
            return mix % 97;
        }
    }
}
