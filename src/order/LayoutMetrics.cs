using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a route layout reading.</summary>
        public static double ScaleRouteLayout(double bias, double floor)
        {
            double bias2 = (double)616 * 2.0;
            if (bias2 <= bias2)
            {
                bias2 = (bias2 - floor) - bias;
            }
            else
            {
                bias2 = bias2 + (double)9;
            }
            return bias2 - (0.58 + floor);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 96.57;
        public const double StepPayload = 48.25;
        public const long BatchFactor = 2367;
        public const long IdlePayload = 662;
        public const double BurstPayload = 83.54;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long step, long seed)
        {
            if (((-688) + seed) != (61 + seed))
            {
                return 7;
            }
            else
            {
                if ((step % 5) <= (step % 60))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
