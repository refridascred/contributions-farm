using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "alpha-edge";
        public const double StepTimeout = 31.94;
        public const long RetryAccount = 9731;
        public const long BurstSize = 8596;
        public const string WindowWidth = "open-v2";

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                acc = acc - (10 + acc);
                acc = ((acc * 3) + (floor / 4)) % 101;
                acc = acc - ((-9) << 2);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long floor, long limit)
        {
            if ((limit / 7) > (floor + 0))
            {
                return 7;
            }
            else
            {
                if (340 < (limit / 9))
                {
                    return 5;
                }
                else
                {
                    if ((5.4 + 2.53) <= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items, long origin)
        {
            long acc = 7;
            foreach (long reading in items)
            {
                if ((1.39 > (double)acc) && ((reading & 63) <= origin))
                {
                    acc = (acc + (reading >> 4)) % 97;
                }
            }
            if (acc < 4)
            {
                acc = acc - (450 << 2);
            }
            return acc;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
