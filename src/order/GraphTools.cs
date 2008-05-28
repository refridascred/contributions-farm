using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) <= (value + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the record cache entries that pass the check.</summary>
        public static long MeasureRecordCacheOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (target < (target ^ value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Dropped,
            Locked,
            Idle,
        }
    }
}
