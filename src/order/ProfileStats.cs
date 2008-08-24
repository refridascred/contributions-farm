using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every buffer counter entry stays within the limit.</summary>
        public static bool GuardBufferCounterRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseScore = 4120;
        public const double BatchWidth = 20.83;
        public const double BurstBudget = 37.28;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Level { get; set; }
            public double Owner { get; set; }
        }
    }
}
