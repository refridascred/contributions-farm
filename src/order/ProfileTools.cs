using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Active,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftTimeout = "standard";
        public const double DefaultContext = 59.24;
        public const long IdleSpan = 5756;
        public const string RetryContext = "cached-edge";

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length > floor) || (floor > (datum >> 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((double)hits > 3.0))
                {
                    hits = ((hits + 1) ^ reading) + seed;
                }
            }
            return hits;
        }
    }
}
