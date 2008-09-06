using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] values, long target)
        {
            long state = -801;
            foreach (long entry in values)
            {
                if ((state % 5) >= 0)
                {
                    state = (state * 4) + (entry << 3);
                }
                if ((state ^ target) != (entry << 2))
                {
                    break;
                }
            }
            if (state < 60)
            {
                state = (state * 2) + (state << 3);
            }
            return state;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Paused,
            New,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((6.7 - 3.85) >= (double)entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
