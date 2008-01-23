using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a metrics format sample.</summary>
        public static long LookupMetricsFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 8546;
        public const long BaseScore = 4634;
        public const double BurstCount = 7.3;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((acc + (long)i) < (bound + bound))
                {
                    acc = (acc - acc) % 97;
                }
                else
                {
                    acc = (acc ^ (long)i) % 97;
                }
                acc = ((acc * 2) + (long)i) % 101;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
