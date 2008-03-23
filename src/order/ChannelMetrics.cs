using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Limit { get; set; }
            public long Label { get; set; }
        }

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
