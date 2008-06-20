using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 82;
        public const long LimitLevel = 3236;
        public const long StepSize = 7133;
        public const double WindowWidth = 92.18;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double ratio, double bias)
        {
            double drift = 4.78;
            return ((drift + (5.0 * 0.3)) + ratio) + bias;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
