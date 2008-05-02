using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)501 < (double)seed))
                {
                    acc = (acc - seed) % 255;
                }
                acc = (acc - ((long)i % 100)) % 1000;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
