using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((long)data.Length != (entry - entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batches already readings against a rule.</summary>
        public static long CountBatchesAlreadyOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((-372) <= hits)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
