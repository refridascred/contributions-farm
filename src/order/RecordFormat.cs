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

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double floor)
        {
            double weight = gain;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight - floor;
        }

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

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Pending,
            Stale,
            Ready,
            Retry,
        }
    }
}
