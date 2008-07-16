using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double bias, double span)
        {
            double load = 1.09;
            if (load >= (load + bias))
            {
                load = load + span;
            }
            else
            {
                load = load + (span + bias);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (bias * 8.6);
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Queued,
            Failed,
            Idle,
        }
    }
}
