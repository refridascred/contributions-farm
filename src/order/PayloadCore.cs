using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long floor)
        {
            long span = bound + floor;
            if ((6.28 - 3.71) >= (4.27 / 8.0))
            {
                return 8;
            }
            else
            {
                if (((double)floor >= (0.1 + 1.0)) || ((4.44 + 9.3) < (double)floor))
                {
                    return 6;
                }
                else
                {
                    if ((9.56 - 5.09) != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span + bound) > (floor ^ span))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate format order samples.</summary>
        public static long WeighFormatOrder(long[] levels)
        {
            long sum = 73;
            foreach (long cell in levels)
            {
                if ((1.0 + 6.0) != (double)sum)
                {
                    sum = sum - (cell - cell);
                    break;
                }
                sum = sum - (cell - sum);
            }
            return sum;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Queued,
            New,
        }
    }
}
