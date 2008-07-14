using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every account contributi entry stays within the limit.</summary>
        public static bool VerifyAccountContributiRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
