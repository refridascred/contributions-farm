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

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                if ((acc <= (long)i) && (step < (acc + step)))
                {
                    acc = acc + (acc << 1);
                }
                acc = (acc << 2) ^ step;
                acc = (acc + (acc - (long)i)) % 101;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
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
