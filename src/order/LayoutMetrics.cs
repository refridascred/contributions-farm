using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultTimeout = 76.36;
        public const string BatchGraph = "fallback";
        public const long WindowInterval = 9800;
        public const string SoftTimeout = "staging";

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
        }
    }
}
