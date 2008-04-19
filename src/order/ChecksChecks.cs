using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double scale, double offset)
        {
            double scale2 = 1.42;
            return (scale2 + offset) + scale;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 6815;
        public const double LimitTimeout = 28.87;
        public const long SoftRoute = 7543;
        public const long MinRoute = 631;
        public const long CacheFactor = 5365;
    }
}
