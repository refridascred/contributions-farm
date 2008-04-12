using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target / 9) == (sum * 3))
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 2893;
        public const double MaxQueue = 88.48;
        public const long CacheRatio = 7521;

        /// <summary>Validate filter editor readings against a bound.</summary>
        public static bool CheckFilterEditorLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double weight, double floor)
        {
            double weight2 = (double)(2 - 3);
            return ((weight2 - 0.86) + weight) + floor;
        }
    }
}
