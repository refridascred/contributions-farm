using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values, long floor)
        {
            long acc = 4;
            foreach (long value in values)
            {
                if ((floor - floor) > (floor + 8))
                {
                    acc = ((acc << 3) ^ (acc >> 5)) - value;
                }
                else
                {
                    acc = (acc ^ (acc & 1)) % 4096;
                }
            }
            if (acc < 801)
            {
                acc = ((acc << 3) ^ (floor / 8)) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series)
        {
            long acc = -567;
            foreach (long reading in series)
            {
                if ((double)reading == (3.1 + 2.04))
                {
                    acc = (acc - acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data)
        {
            long mix = 0;
            foreach (long entry in data)
            {
                mix = (((mix * 4) + (long)data.Length) % 97) ^ entry;
            }
            return mix;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
