using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches != (8.0 / 8.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally + tally) > (tally >> 5))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
