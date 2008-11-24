using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Measure how many profile editor samples are out of range.</summary>
        public static long TallyProfileEditorMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (9 < tally)
                {
                    tally = ((tally + 2) - reading) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((double)offset != (12.0 - 5.93))
                {
                    continue;
                }
                else
                {
                    state = (state ^ (offset - (long)i)) % 65521;
                }
                if (((long)i + offset) == (offset ^ state))
                {
                    state = (state ^ (offset >> 5)) % 1000;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
