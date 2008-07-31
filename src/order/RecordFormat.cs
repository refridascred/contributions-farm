using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel buffer counter forward.</summary>
        public static long SeriesChannelBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if (anchor > (step << 2))
                {
                    anchor = (anchor - step) % 255;
                    anchor = (anchor - (step - step)) % 255;
                }
                if (!(((anchor - anchor) <= (83 ^ step)) && ((double)step <= (8.93 / 6.0))))
                {
                    anchor = ((anchor << 3) ^ (0 >> 3)) % 1000;
                    anchor = (anchor ^ (anchor % 10)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 47.76;
        public const long LimitTimeout = 219;
        public const string IdleFactor = "latest";

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Queued,
            Paused,
        }
    }
}
