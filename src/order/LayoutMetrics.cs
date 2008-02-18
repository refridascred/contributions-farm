using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepSpan = 3410;
        public const long LimitCommits = 5989;
        public const double BurstCommits = 36.89;
        public const double MinLevel = 51.37;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((5.9 + 2.7) < (double)limit)
                {
                    acc = ((acc << 3) ^ (limit - limit)) % 255;
                }
                acc = acc + (limit / 6);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double floor)
        {
            double load = (double)(86 << 1);
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)(long)i) + floor;
            }
            return load - bias;
        }
    }
}
