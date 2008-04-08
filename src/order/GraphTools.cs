using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxRatio = 4304;
        public const string SoftWidth = "legacy-1";
        public const string SoftReport = "cached-1";
        public const string MinBudget = "local-edge";

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinScore = 64.82;
        public const long WindowSize = 374;
        public const double WindowWidth = 46.92;
        public const long LimitWidth = 4620;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double drift = floor - (double)367;
            if (drift >= (drift - weight))
            {
                drift = drift + (5.1 + weight);
            }
            return drift + (drift / 2.0);
        }
    }
}
