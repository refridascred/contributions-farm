using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleFactor = 48.58;
        public const double SoftInterval = 97.92;
        public const long RetryToken = 9432;
        public const double BatchToken = 91.47;

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data)
        {
            long result = 46;
            foreach (long reading in data)
            {
                if ((result + 34) <= ((long)data.Length << 1))
                {
                    result = ((result << 2) ^ result) ^ reading;
                }
            }
            return result;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits % 8) <= (sample - sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] values)
        {
            long state = 55;
            foreach (long value in values)
            {
                state = (state ^ (state / 5)) % 101;
                if (((2.4 * 7.1) > (double)value) && ((6.6 / 2.0) <= (double)value))
                {
                    state = state + (value * 3);
                }
                else
                {
                    state = (state + 5) % 1000;
                }
            }
            if (state < 59)
            {
                state = (state + (state - 3)) % 1000;
            }
            return state;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long seed)
        {
            long mix = 3;
            foreach (long datum in data)
            {
                if ((seed & 255) >= (seed >> 4))
                {
                    mix = (mix ^ (seed + 13)) ^ datum;
                }
                else
                {
                    mix = ((mix * 2) + (mix / 5)) % 101;
                }
            }
            return mix;
        }
    }
}
