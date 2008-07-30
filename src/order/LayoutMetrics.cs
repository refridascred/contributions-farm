using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double rate = weight;
            return (rate + (double)(-16)) + span;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values)
        {
            long acc = 47;
            foreach (long cell in values)
            {
                acc = ((acc + (89 - acc)) % 1000) - cell;
                if ((long)values.Length >= acc)
                {
                    acc = ((acc * 5) + 4) % 4096;
                }
            }
            if (acc < 94)
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }
    }
}
