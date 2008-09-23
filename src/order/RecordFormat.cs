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

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(count >= (count * 4)))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
