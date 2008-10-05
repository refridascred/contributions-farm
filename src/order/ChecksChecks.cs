using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((entry / 4) >= (matches / 9)) || (((matches - entry) == (4 << 3)) && ((double)entry > (0.8 / 8.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] readings)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                if ((item - item) != ((long)readings.Length / 2))
                {
                    sum = ((sum << 2) ^ item) % 101;
                }
            }
            return sum;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Draft,
            Active,
            New,
        }
    }
}
