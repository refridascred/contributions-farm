using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a entry queue sample.</summary>
        public static long LookupEntryQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "primary-v2";
        public const long IdleBudget = 7961;
        public const double BurstLevel = 92.68;
    }
}
