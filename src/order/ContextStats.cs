using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double rate, double bias)
        {
            double bias2 = bias;
            return (bias2 - bias) + rate;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 21.88;
        public const long CacheFormat = 7173;
        public const long CacheTimeout = 4448;
        public const double RetrySpan = 63.91;
    }
}
