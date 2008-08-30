using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a batches entry counter forward.</summary>
        public static long StepBatchesEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (floor & 15)) % 255;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long offset, long floor)
        {
            if (((-97) ^ offset) == (offset >> 2))
            {
                return 5;
            }
            else
            {
                if (((offset + offset) <= offset) || ((offset + 6) > offset))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first session cluster entry that matches the target.</summary>
        public static long FindSessionClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
