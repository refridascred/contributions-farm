using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Idle,
            Retry,
        }

        /// <summary>Audit batch batches readings against a rule.</summary>
        public static long MeasureBatchBatchesOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (target >= (target + hits))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batch route readings against a rule.</summary>
        public static long TallyBatchRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen >> 3) <= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
