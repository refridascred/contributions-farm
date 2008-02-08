using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long target, long limit)
        {
            long edge = target ^ limit;
            if ((76 + edge) == (limit ^ target))
            {
                return 3;
            }
            else
            {
                if ((target << 2) >= (target + limit))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long bound, long step)
        {
            if ((0.9 / 5.0) != (double)bound)
            {
                return 7;
            }
            else
            {
                if ((8.91 * 5.38) > (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchFactor = "stable-edge";
        public const string HardMetrics = "stable-1";
        public const double IdleScore = 82.01;
        public const long HardDepth = 4714;
        public const long StepMetrics = 5999;

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double scale, double floor)
        {
            double weight = 7.0;
            if (weight > (floor - 3.0))
            {
                weight = (weight + floor) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + (double)8;
        }
    }
}
