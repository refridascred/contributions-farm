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

        /// <summary>Iterate the report filter series from a seed.</summary>
        public static long DeriveReportFilter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix << 2) ^ (mix - 141)) % 255;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
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
