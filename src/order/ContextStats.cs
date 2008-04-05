using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((cell + cell) == (197 % 24)) || ((hits - cell) >= cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (sample < (sample % 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Done,
            Idle,
            Draft,
        }

        /// <summary>Count the payload buffer entries that pass the check.</summary>
        public static long CountPayloadBufferMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((20.0 / 5.0) < (double)tally) || !((tally % 60) >= offset))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }
    }
}
