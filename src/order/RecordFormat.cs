using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((double)limit > (13.0 * 9.2)) && ((89 << 2) <= (item & 127)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a farm editor sample.</summary>
        public static long LookupFarmEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)offset > (4.43 + 0.3))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Closed,
            Idle,
            Queued,
            Paused,
        }
    }
}
