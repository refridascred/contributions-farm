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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
