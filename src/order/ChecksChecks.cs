using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 93.66;
        public const double CacheTimeout = 2.56;
        public const string BatchScore = "latest-1";
        public const long DefaultTimeout = 878;

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + (4.0 - ratio)) + (double)(long)i) - floor;
            }
            return ratio - (double)21;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((seed << 3) > (seed + mix)) || ((seed - seed) >= seed))
                {
                    mix = mix - mix;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
