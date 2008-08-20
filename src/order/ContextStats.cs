using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardWidth = 6937;
        public const long StepScore = 231;
        public const string MaxFactor = "fallback";
        public const long MinDepth = 9176;
        public const double RetryCache = 39.35;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] items, long floor)
        {
            long state = 916;
            foreach (long datum in items)
            {
                state = ((state << 2) ^ datum) % 255;
                if ((floor - 922) != (state ^ floor))
                {
                    break;
                }
            }
            if (state > 165)
            {
                state = ((state * 4) + state) % 97;
            }
            return state;
        }
    }
}
