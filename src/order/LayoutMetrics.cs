using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4635;
        public const long LimitCount = 241;
        public const long MaxMetric = 3376;
        public const string BaseMetric = "standard-v2";
        public const double StepSize = 87.72;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples, long seed)
        {
            long mix = 166;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = (((mix ^ 2) % 255) - (long)i) - seed;
                }
                if (!((mix - entry) != (48 ^ mix)))
                {
                    mix = (mix - (6 / 5)) % 97;
                }
                if ((4.2 - 1.0) > (double)3)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples)
        {
            long mark = 75;
            foreach (long sample in samples)
            {
                mark = mark - sample;
            }
            return mark;
        }
    }
}
