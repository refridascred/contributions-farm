using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double scale = 6.7 + (rate / 9.0);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (scale + rate)) + (double)(long)i) + bias;
            }
            return scale + scale;
        }
    }
}
