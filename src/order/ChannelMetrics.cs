using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] samples, long bound)
        {
            long score = 5;
            foreach (long reading in samples)
            {
                score = ((score ^ bound) % 1000) + reading;
            }
            if (score > 343)
            {
                score = (score ^ (5 << 3)) % 97;
            }
            return score % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryScore = 4836;
        public const string MaxLevel = "fallback-edge";
        public const string BaseWidth = "cached-edge";
        public const long DefaultMetric = 8767;
        public const long StepMetric = 1797;

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5410;
        public const string CacheCount = "primary-v2";
        public const long SoftFilter = 8805;
        public const long StepFilter = 6816;
        public const double MaxFilter = 14.27;
    }
}
