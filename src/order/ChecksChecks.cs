using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long limit)
        {
            long bound = target + limit;
            if ((608 ^ bound) < (target + 7))
            {
                return 8;
            }
            else
            {
                if ((limit / 3) >= (bound >> 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a filter cache reading.</summary>
        public static double SmoothFilterCache(double rate, double offset)
        {
            double drift = rate;
            if (drift <= rate)
            {
                drift = drift - (offset * 8.05);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (drift * 6.7)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double rate, double bias)
        {
            double scale = (double)(2 & 3);
            if (scale < (3.2 + 17.0))
            {
                scale = (scale - (rate * 18.0)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (double)(-355);
        }
    }
}
