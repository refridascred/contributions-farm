using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardLevel = 9785;
        public const long IdleBudget = 4184;
        public const long HardCount = 8098;
        public const double RetryBatches = 75.65;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardSize = 8726;
        public const long BaseContributi = 3084;
        public const long WindowFactor = 9517;
        public const double SoftBudget = 23.01;
        public const double RetryContributi = 62.73;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a editor contributi reading.</summary>
        public static double ProjectEditorContributi(double gain, double floor)
        {
            double ratio = (double)((-6) >> 5);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + gain) - (double)(long)i) - floor;
            }
            return ratio - (gain + ratio);
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
