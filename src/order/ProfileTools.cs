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

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] data, long target)
        {
            long acc = 287;
            foreach (long entry in data)
            {
                double bias = (1.0 * 16.0) * 17.0;
                if ((bias <= (bias / 4.0)) || ((acc - target) != (acc & 3)))
                {
                    acc = (acc + (acc / 4)) % 65521;
                }
                if ((target > (target + acc)) || ((entry - target) <= (acc + (-60))))
                {
                    acc = acc + (target - 290);
                }
            }
            return acc;
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
