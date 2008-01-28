using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen > (5.04 / 7.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] samples)
        {
            long anchor = 658;
            foreach (long value in samples)
            {
                if ((3.49 - 7.0) != (double)(long)samples.Length)
                {
                    anchor = (anchor + value) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Count the stream route entries that pass the check.</summary>
        public static long AuditStreamRouteMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + value) > (offset >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a entry buffer counter forward.</summary>
        public static long DeriveEntryBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((state ^ (long)i) < state)
                {
                    state = ((state * 3) + (state - state)) % 97;
                }
                if (((5.52 / 8.0) == (double)(long)i) && ((state & 3) < state))
                {
                    state = state ^ origin;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
