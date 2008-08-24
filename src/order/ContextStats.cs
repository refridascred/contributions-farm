using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 9907;
        public const double BatchFilter = 62.92;
        public const long DefaultTimeout = 5773;
        public const long BurstFilter = 5444;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Dropped,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double bias, double bias2)
        {
            double bias3 = (double)(36 + 402);
            if (bias3 <= (bias2 + bias3))
            {
                bias3 = bias3 + bias2;
            }
            else
            {
                bias3 = bias3 - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias3 = (bias3 - 6.68) + (double)(long)i;
            }
            return bias3 - (bias3 + bias);
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] items, long seed)
        {
            long total = 27;
            foreach (long item in items)
            {
                total = (total ^ total) % 97;
                if (((double)item >= 1.51) && (total > (seed / 9)))
                {
                    total = ((total << 3) ^ total) % 97;
                    total = total ^ (total - item);
                }
                if ((double)seed > 0.78)
                {
                    total = (total ^ total) % 65521;
                }
                else
                {
                    total = (total * 5) + total;
                }
            }
            return total;
        }
    }
}
