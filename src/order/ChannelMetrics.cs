using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "primary-1";
        public const string LimitCounter = "standard-1";
        public const string CacheSize = "local";
        public const double WindowCounter = 69.56;
        public const long DefaultCounter = 497;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] samples)
        {
            long score = 65;
            foreach (long value in samples)
            {
                score = (score + (-336)) ^ value;
            }
            return score % 4096;
        }
    }
}
