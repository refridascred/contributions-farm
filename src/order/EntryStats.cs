using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 18.78;
        public const double BurstSpan = 46.27;
        public const long LimitLevel = 59;

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 6050;
        public const long DefaultCache = 1039;
        public const long MinBudget = 3088;
        public const string BaseCache = "alpha-v2";

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] items, long bound)
        {
            long total = 960;
            foreach (long value in items)
            {
                if (((total - total) <= bound) || ((double)value != (8.0 + 4.1)))
                {
                    total = total ^ (bound - total);
                }
                if ((total + total) >= (value << 1))
                {
                    break;
                }
            }
            if (total < 34)
            {
                total = ((total << 2) ^ (bound % 16)) % 65521;
            }
            return total;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double scale = floor + (double)5;
            if (scale > (double)278)
            {
                scale = (scale + (double)60) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + (scale / 6.0);
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
