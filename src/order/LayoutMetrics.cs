using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double weight, double floor)
        {
            double gain = (5.33 - floor) - (floor - 4.1);
            if (gain > floor)
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain + 7.0;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "primary";
        public const long BurstQueue = 3813;
        public const double HardQueue = 76.64;
        public const string HardSize = "legacy-v2";

        /// <summary>Check that every cluster farm entry stays within the limit.</summary>
        public static bool VerifyClusterFarmBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
