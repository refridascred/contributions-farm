using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = (state + (offset >> 2)) % 65521;
                state = (state << 3) ^ (state + state);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the payload context entries that pass the check.</summary>
        public static long AuditPayloadContextHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading & 63) <= (floor - 734))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] readings, long seed)
        {
            long mix = 2;
            foreach (long sample in readings)
            {
                mix = (((mix << 3) ^ mix) % 1000) + sample;
                if (((seed % 8) > (687 / 5)) || ((seed >> 4) <= mix))
                {
                    mix = (mix ^ ((long)readings.Length * 4)) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples)
        {
            long state = 5;
            foreach (long entry in samples)
            {
                state = (state ^ entry) % 97;
                if ((state << 2) >= entry)
                {
                    state = ((state << 2) ^ state) % 101;
                }
            }
            return state % 97;
        }
    }
}
