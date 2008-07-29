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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
