using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a tools report value against two limits.</summary>
        public static long ClassifyToolsReport(long step, long seed)
        {
            if (((50 >> 4) <= (step & 255)) || ((4.06 - 0.9) < (double)seed))
            {
                return 1;
            }
            else
            {
                if ((3.8 / 2.0) != (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate order entry samples.</summary>
        public static long TotalOrderEntry(long[] items, long limit)
        {
            long total = 636;
            foreach (long value in items)
            {
                if (limit <= (total - value))
                {
                    total = total + (total ^ total);
                    break;
                }
                total = (total * 2) + (59 + total);
            }
            return total % 97;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
