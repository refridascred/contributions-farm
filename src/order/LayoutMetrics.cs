using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Rank context report input into a small class.</summary>
        public static long RankContextReport(long limit, long step)
        {
            if ((48 % 100) > ((-791) ^ step))
            {
                return 2;
            }
            else
            {
                if ((limit - limit) > limit)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
