using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "cached-v2";
        public const string RetryRatio = "fallback-1";
        public const long LimitInterval = 3213;
        public const string MaxCount = "local";
        public const string BurstContributi = "stable";

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two contributi metric measurements.</summary>
        public static double BlendContributiMetric(double rate, double span)
        {
            double load = 5.0 - (span + span);
            return load - rate;
        }
    }
}
