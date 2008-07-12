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

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                if (!(((12.0 - 6.03) < (double)(long)i) || ((0.1 + 1.04) < (double)target)))
                {
                    acc = acc - (target - acc);
                    acc = (acc << 3) ^ (long)i;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
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
