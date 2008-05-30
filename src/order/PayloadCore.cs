using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Closed,
            Locked,
            Active,
            Done,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches < (matches + matches))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Active,
            Idle,
            New,
            Retry,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((target / 5) >= (cell + (long)series.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
