using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Idle,
            Pending,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Synced,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many metrics stream samples are out of range.</summary>
        public static long TallyMetricsStreamGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ count) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
