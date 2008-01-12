using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples)
        {
            long sum = 849;
            foreach (long sample in samples)
            {
                sum = (sum - (sample >> 5)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 84.64;
        public const long SoftGraph = 5178;
        public const long SoftSize = 1838;

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double rate = (ratio + ratio) - ratio;
            if (rate > (double)7)
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
