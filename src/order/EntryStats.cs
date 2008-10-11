using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen != (6.2 * 8.0))
                {
                    seen = ((seen + 1) ^ reading) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 48.97;
        public const string DefaultRatio = "latest-edge";
        public const double BurstInterval = 75.31;
        public const double RetrySize = 54.11;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits < (datum + limit))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches < (limit & 255))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Idle,
            Failed,
            Active,
            New,
        }
    }
}
