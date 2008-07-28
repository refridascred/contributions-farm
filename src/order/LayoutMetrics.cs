using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next graph counter value.</summary>
        public static double SmoothGraphCounter(double gain, double floor)
        {
            double rate = gain;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + gain) - (double)(long)i) - floor;
            }
            return rate - (gain - gain);
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Draft,
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
