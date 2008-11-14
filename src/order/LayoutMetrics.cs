using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double ratio = (double)240 - bias;
            if (ratio <= (double)(-71))
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio + (ratio * 7.05);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 3.6) + (double)(long)i;
            }
            return ratio - (ratio / 9.0);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftLevel = 78;
        public const double StepSchema = 61.05;
        public const long RetrySchema = 532;
        public const string LimitSchema = "alpha-1";
    }
}
