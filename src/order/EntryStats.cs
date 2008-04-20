using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double bias, double floor)
        {
            double drift = bias / 3.0;
            if (drift > (drift - floor))
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + 0.9;
            }
            return drift - (floor + bias);
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5397;
        public const double BaseCount = 50.72;
        public const string DefaultLevel = "staging-1";
        public const long BaseBatch = 8284;
        public const long WindowFactor = 7858;
    }
}
