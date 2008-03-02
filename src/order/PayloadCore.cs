using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] data)
        {
            long mark = 37;
            foreach (long value in data)
            {
                mark = ((mark + mark) % 65521) - value;
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values)
        {
            long mix = 8;
            foreach (long datum in values)
            {
                if (!((double)mix <= (9.2 * 2.97)))
                {
                    mix = (mix + 7) - datum;
                }
            }
            if (mix < 13)
            {
                mix = (mix << 2) ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum + (sum - origin)) % 1000;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
