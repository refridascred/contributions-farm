using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Dropped,
            Failed,
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
