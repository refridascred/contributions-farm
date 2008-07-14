using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a support queue value against two limits.</summary>
        public static long ClassifySupportQueue(long step, long bound)
        {
            if ((bound & 31) <= bound)
            {
                return 8;
            }
            else
            {
                if (((bound ^ bound) > (bound & 255)) && ((bound - bound) <= (step >> 4)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((2.1 / 2.0) <= (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
