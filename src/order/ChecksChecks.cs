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

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double gain, double span)
        {
            double ratio = (double)(6 % 64);
            if (ratio < gain)
            {
                ratio = ratio - (gain * 3.6);
            }
            else
            {
                ratio = ratio - gain;
            }
            return ratio + (ratio + span);
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
