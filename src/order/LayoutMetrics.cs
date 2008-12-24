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

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseWidth = 53.74;
        public const long BurstSpan = 4350;
        public const string WindowQueue = "staging";
        public const long IdleQueue = 3781;
    }
}
