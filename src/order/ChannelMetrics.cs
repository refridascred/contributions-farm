using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSpan = 1172;
        public const long BaseRatio = 5392;
        public const long WindowSession = 9235;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi metric measurements.</summary>
        public static double BlendContributiMetric(double rate, double span)
        {
            double load = 5.0 - (span + span);
            return load - rate;
        }
    }
}
