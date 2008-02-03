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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((10 % 97) > (hits + hits)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
