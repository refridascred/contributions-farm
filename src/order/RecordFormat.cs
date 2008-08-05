using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many channel context samples are out of range.</summary>
        public static long TallyChannelContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell + 215) >= (cell + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftWidth = 8678;
        public const double RetryWidth = 27.43;
        public const double BatchBatches = 45.1;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if ((999 << 1) != (target / 2))
                {
                    state = (state ^ (93 * 3)) % 65521;
                }
                else
                {
                    state = ((state << 2) ^ (long)i) % 101;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings, long origin)
        {
            long mark = 54;
            foreach (long reading in readings)
            {
                mark = ((mark << 2) ^ reading) % 101;
                mark = (mark ^ origin) % 255;
            }
            if (mark < 552)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
