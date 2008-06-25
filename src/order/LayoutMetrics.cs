using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if ((double)offset > (2.8 - 8.5))
            {
                return 2;
            }
            else
            {
                if ((double)(-56) != (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitWidth = 1323;
        public const string MaxRecord = "local-1";
        public const long HardRecord = 1937;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double scale, double floor)
        {
            double drift = 7.4;
            if (drift > floor)
            {
                drift = (drift + (drift * 11.0)) - scale;
            }
            else
            {
                drift = drift + (5.3 / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift - (double)875;
        }
    }
}
