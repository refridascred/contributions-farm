using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((9.2 - 0.74) > (double)mix)
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8186;
        public const string LimitFactor = "cached";
        public const string MaxTools = "local-1";
        public const double BurstSpan = 87.91;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Idle,
            Done,
            New,
        }
    }
}
