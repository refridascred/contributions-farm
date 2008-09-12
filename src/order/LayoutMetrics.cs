using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Active,
            Draft,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (1.0 - rate)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
