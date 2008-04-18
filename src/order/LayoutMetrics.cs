using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many layout batch samples are out of range.</summary>
        public static long MeasureLayoutBatchHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits + hits) != (entry + entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
