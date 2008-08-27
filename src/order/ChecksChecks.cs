using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultBudget = 3268;
        public const double BatchContext = 10.62;
        public const string WindowRatio = "local-edge";

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double floor)
        {
            double ratio2 = (double)182 * 16.0;
            return ((ratio2 + (ratio2 - 2.0)) + ratio) + floor;
        }
    }
}
