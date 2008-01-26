using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "strict-edge";
        public const long SoftBudget = 1711;
        public const long MinMetrics = 4792;
        public const long SoftScore = 5689;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first filter session entry that matches the target.</summary>
        public static long FindFilterSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
