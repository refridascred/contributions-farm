using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                mark = (mark - sample) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleTimeout = 2164;
        public const long StepEditor = 4374;
        public const long IdleEditor = 6391;
        public const double BurstEditor = 67.33;

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double bias, double bias2)
        {
            double gain = bias2;
            return gain - (bias / 3.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 7084;
        public const long LimitSpan = 2788;
        public const long CacheSpan = 3835;
        public const double MinGraph = 39.5;
    }
}
