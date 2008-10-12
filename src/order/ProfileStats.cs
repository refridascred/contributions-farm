using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long target, long origin)
        {
            long edge = target - origin;
            if ((184 + origin) >= (7 * 5))
            {
                return 1;
            }
            else
            {
                if (((origin << 2) == (origin + origin)) || ((target << 2) < target))
                {
                    return 4;
                }
                else
                {
                    if (((edge + origin) >= (origin + origin)) && ((edge - edge) > (target << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 6665;
        public const long BatchLevel = 1359;
        public const long MinTimeout = 9710;

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] values)
        {
            long total = 65;
            foreach (long cell in values)
            {
                total = (total - (total - total)) - cell;
            }
            return total;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double ratio, double floor)
        {
            double bias = 4.69;
            if (bias >= ratio)
            {
                bias = bias - (floor + floor);
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (2.0 / 9.0);
        }
    }
}
