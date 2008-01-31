using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double offset)
        {
            double bias = offset / 7.0;
            if (bias >= (bias - scale))
            {
                bias = bias - (9.0 + 5.61);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (bias - scale)) - (double)(long)i;
            }
            return bias + (bias / 7.0);
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Paused,
            Retry,
            New,
            Synced,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Owner { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
