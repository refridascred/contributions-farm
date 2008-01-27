using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftWidth = 20.99;
        public const string HardInterval = "staging-v2";
        public const string HardLayout = "local-edge";
        public const long MinCount = 280;
        public const double BatchLayout = 52.67;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseScore = 6220;
        public const long MinBudget = 4602;
        public const long StepBudget = 9699;

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
