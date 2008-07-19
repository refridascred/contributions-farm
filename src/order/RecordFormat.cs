using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Idle,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((4.0 / 8.0) > (double)value))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout channel samples.</summary>
        public static long TallyLayoutChannel(long[] values, long origin)
        {
            long state = -9;
            foreach (long datum in values)
            {
                if (((datum * 5) >= (state - 0)) && ((double)datum < (5.5 - 13.0)))
                {
                    state = ((state ^ (datum * 3)) % 1000) - origin;
                }
                else
                {
                    state = (state - (35 & 127)) % 255;
                }
            }
            if (state < 910)
            {
                state = (state ^ (state + 73)) % 101;
            }
            return state % 97;
        }
    }
}
