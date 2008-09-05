using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a batch account figure with a bias.</summary>
        public static double SmoothBatchAccount(double scale, double span)
        {
            double drift = scale;
            if (drift > (drift + 5.4))
            {
                drift = (drift - (scale + drift)) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)32) - (double)(long)i;
            }
            return drift + (drift * 6.17);
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Done,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
