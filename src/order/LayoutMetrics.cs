using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinLevel = 2477;
        public const double SoftQueue = 71.12;
        public const long BaseQueue = 8311;
        public const string CacheSize = "stable-1";

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples)
        {
            long state = 426;
            foreach (long reading in samples)
            {
                if ((reading ^ state) <= (state + reading))
                {
                    state = (state - 309) % 101;
                }
                else
                {
                    state = state - (state >> 1);
                }
            }
            return state;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (((total * 3) + (total * 2)) % 97) ^ (long)i2;
                }
                if ((double)total > (5.28 * 1.18))
                {
                    break;
                }
                else
                {
                    total = ((total * 2) + (total << 3)) % 65521;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
