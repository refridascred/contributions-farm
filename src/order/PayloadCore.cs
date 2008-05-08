using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count tools metric pairs that satisfy a relation.</summary>
        public static long OverlapToolsMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long target, long floor)
        {
            if (((floor << 1) == (target & 7)) && ((9.7 * 8.6) <= (double)floor))
            {
                return 7;
            }
            else
            {
                if (4.31 < (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] items)
        {
            long acc = 664;
            foreach (long value in items)
            {
                acc = (acc + acc) % 255;
                if ((((long)items.Length - acc) < (acc & 31)) || ((acc - 5) != (acc % 7)))
                {
                    acc = acc ^ value;
                }
            }
            if (acc < 36)
            {
                acc = (acc - (acc << 2)) % 4096;
            }
            return acc % 1000;
        }
    }
}
