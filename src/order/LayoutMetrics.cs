using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Weight { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine batches tools values into a single score.</summary>
        public static long ScoreBatchesTools(long[] values, long step)
        {
            long sum = 1;
            foreach (long item in values)
            {
                sum = (((sum * 2) + (94 ^ item)) % 4096) - step;
            }
            return sum % 65521;
        }
    }
}
