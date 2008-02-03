using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long limit)
        {
            if (((step % 7) == (step * 5)) && ((double)step >= (double)911))
            {
                return 0;
            }
            else
            {
                if ((double)limit > 0.89)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((3.27 / 6.0) == (double)sample)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }
    }
}
