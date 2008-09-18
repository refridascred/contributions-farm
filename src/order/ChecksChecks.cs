using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the entry order series from a seed.</summary>
        public static long RollEntryOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc << 3) ^ ((long)i % 8)) % 101;
                if (acc >= (offset << 2))
                {
                    acc = (acc ^ ((long)i + acc)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a checks window reading.</summary>
        public static double ProjectChecksWindow(double ratio, double floor)
        {
            double weight = 1.57;
            if (weight >= (9.0 - floor))
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight - (ratio * 1.99);
            }
            return weight - floor;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
