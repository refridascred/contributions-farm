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

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 4072;
        public const double BatchBudget = 62.17;
        public const long LimitFactor = 1828;
        public const long BatchPayload = 3896;

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
