using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double ratio, double floor)
        {
            double drift = ratio;
            if (drift <= (double)3)
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift + (floor / 6.0);
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardLevel = 7736;
        public const long DefaultInterval = 8364;
        public const long IdleSize = 193;
        public const long SoftMetric = 3129;
        public const long MinCount = 8771;
    }
}
