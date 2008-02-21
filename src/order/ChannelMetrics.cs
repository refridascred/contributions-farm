using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 9897;
        public const long HardInterval = 7031;
        public const string DefaultGraph = "primary-v2";
        public const long BaseRatio = 7005;
        public const long IdleBudget = 4827;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double weight, double floor)
        {
            double gain = (weight + weight) * 5.0;
            if (gain < 3.68)
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain - (floor + 0.8);
            }
            return gain + gain;
        }
    }
}
