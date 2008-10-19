using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit already contributi readings against a rule.</summary>
        public static long CountAlreadyContributiHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)tally != (double)entry) || ((double)offset != (2.6 / 8.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long AuditPayloadToolsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((value & 63) < value) || (((seen + seen) >= (value + value)) && ((double)seen != (double)value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
