using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 66.04;
        public const double BatchInterval = 72.92;
        public const long StepCommand = 7227;
        public const long LimitCommand = 3840;
        public const double MaxRatio = 30.92;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Scale a stats cluster figure with a bias.</summary>
        public static double ProjectStatsCluster(double ratio, double bias)
        {
            double load = bias;
            if (load >= (double)52)
            {
                load = (load + (double)9) - ratio;
            }
            else
            {
                load = load + (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)855) - (double)(long)i;
            }
            return load - bias;
        }
    }
}
