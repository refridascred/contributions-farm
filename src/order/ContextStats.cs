using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor ^ (limit - limit);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = (state << 2) ^ state;
                state = state ^ ((long)i & 1);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
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
