using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a stats context counter forward.</summary>
        public static long IterateStatsContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                long span = mark + 108;
                mark = (mark + (84 - span)) % 4096;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Grade a account contributi value against two limits.</summary>
        public static long BucketAccountContributi(long step, long seed)
        {
            if (((step << 1) == (step % 12)) || ((seed - seed) == (seed * 4)))
            {
                return 7;
            }
            else
            {
                if (!((double)step > (double)seed))
                {
                    return 2;
                }
                else
                {
                    if (((step - seed) >= (seed + step)) || (step < (375 % 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 77.78;
        public const double BurstTimeout = 98.03;
        public const double BatchTimeout = 47.36;
        public const long RetryAccount = 4670;

        /// <summary>Find the first support format entry that matches the target.</summary>
        public static long LookupSupportFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings)
        {
            long result = 596;
            foreach (long value in readings)
            {
                if (217 <= value)
                {
                    result = (result ^ (27 + value)) % 65521;
                }
                else
                {
                    result = ((result * 2) + value) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
