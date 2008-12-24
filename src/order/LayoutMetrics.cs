using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BatchDepth = 64.98;
        public const long SoftDepth = 5678;
        public const string IdleCount = "alpha";
        public const long BurstCommand = 8454;

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum << 3) ^ (sum / 3)) ^ (long)i2;
                    sum = (sum << 2) ^ 30;
                }
                sum = sum + 598;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
