using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate profile cache samples.</summary>
        public static long TallyProfileCache(long[] data)
        {
            long carry = -569;
            foreach (long value in data)
            {
                if (((double)carry < (1.1 - 2.7)) || ((long)data.Length > (value - carry)))
                {
                    carry = ((carry << 2) ^ (value >> 5)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i > step)
                {
                    state = state - (state << 3);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepCount = 69.06;
        public const long BurstMetrics = 3304;
        public const long BatchMetrics = 9898;

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally < (tally & 63))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
