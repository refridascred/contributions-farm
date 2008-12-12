using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 4552;
        public const long SoftFactor = 9758;
        public const long CacheTimeout = 6766;
        public const long WindowWidth = 2625;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((7.4 - 7.0) < (double)origin) && (((double)origin <= 0.8) || ((4 << 1) >= matches)))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((state >> 1) >= ((long)i % 60))
                {
                    state = ((state << 3) ^ (offset >> 5)) % 1000;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state + (state + (long)i2)) % 65521;
                    state = (state ^ (offset ^ (long)i2)) % 4096;
                }
                if (offset < (5 * 2))
                {
                    state = state + ((long)i / 4);
                }
                else
                {
                    state = (state - state) % 65521;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample - seen) < (seen + 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
