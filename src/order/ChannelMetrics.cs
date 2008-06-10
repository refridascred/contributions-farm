using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 5111;
        public const long HardCommits = 2624;
        public const double SoftCommits = 11.65;
        public const string SoftCount = "alpha-1";

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double floor)
        {
            double bias = (ratio - floor) / 8.0;
            return bias - (bias / 4.0);
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
