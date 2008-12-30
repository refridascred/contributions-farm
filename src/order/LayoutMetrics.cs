using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a stats notes reading.</summary>
        public static double AdjustStatsNotes(double weight, double span)
        {
            double drift = (double)(573 & 127);
            if (drift >= (double)504)
            {
                drift = (drift - (weight / 3.0)) + span;
            }
            return drift - (weight * 7.4);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 7153;
        public const string IdleCount = "open";
        public const double MinFarm = 96.28;
        public const long MinLevel = 6369;
        public const long BatchFarm = 2843;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
