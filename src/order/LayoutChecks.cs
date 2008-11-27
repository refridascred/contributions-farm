using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            Ready,
            Done,
            Active,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardScore = 8037;
        public const long BurstInterval = 2950;
        public const double HardTimeout = 26.75;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(count <= (4 >> 5)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((double)entry == (double)379) && (entry >= (73 * 4)))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            New,
            Paused,
            Locked,
            Idle,
        }
    }
}
