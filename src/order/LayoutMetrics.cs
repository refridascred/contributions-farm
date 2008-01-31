using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 7707;
        public const long SoftMetric = 2323;
        public const string BatchTimeout = "legacy-1";
        public const long HardLevel = 5999;
        public const string StepWidth = "latest-edge";

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin >> 5) >= (18 << 1))
                {
                    result = (result - 0) % 97;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Owner { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
