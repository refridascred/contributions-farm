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

        /// <summary>Validate schema graph readings against a bound.</summary>
        public static bool GuardSchemaGraphBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
