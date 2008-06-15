using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Weight { get; set; }
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftFactor = 5195;
        public const long StepChannel = 1906;
        public const long HardScore = 3621;
        public const string MinFactor = "latest-v2";

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                if ((8.17 - 11.0) >= (1.17 - 2.0))
                {
                    acc = ((acc * 4) + target) % 255;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
