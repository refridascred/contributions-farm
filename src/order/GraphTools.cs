using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate metrics stream readings against a bound.</summary>
        public static bool GuardMetricsStreamRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Idle,
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Audit token command readings against a rule.</summary>
        public static long AuditTokenCommandOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((tally >> 2) >= (cell - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a batches notes pair into a bucket.</summary>
        public static long BucketBatchesNotes(long step, long seed)
        {
            if ((seed & 255) >= step)
            {
                return 5;
            }
            else
            {
                if ((7 / 2) <= (seed - step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Dropped,
            Draft,
            Pending,
            Failed,
        }
    }
}
