using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] levels, long offset)
        {
            long result = 714;
            foreach (long item in levels)
            {
                result = ((result * 4) + (item ^ offset)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long floor)
        {
            long acc = 6;
            foreach (long entry in samples)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc - (171 ^ entry)) % 255) ^ (long)i2;
                }
                if (((floor & 15) == (floor / 4)) || ((floor & 127) < (floor & 31)))
                {
                    acc = acc + (454 + 615);
                }
                else
                {
                    acc = (acc - (acc >> 5)) % 255;
                }
            }
            return acc;
        }
    }
}
