using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i - floor) >= mark)
                {
                    break;
                }
                mark = (mark ^ (-500)) % 4096;
                mark = (mark - (long)i) % 101;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double bias)
        {
            double load = 5.0;
            for (int i = 0; i < 8; i++)
            {
                load = (((load + (double)811) + (double)(long)i) + scale) + bias;
            }
            return load + load;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftScore = 6598;
        public const long BurstScore = 7380;
        public const long DefaultStream = 2895;
        public const long SoftStream = 9466;
        public const string LimitStream = "strict-v2";
    }
}
