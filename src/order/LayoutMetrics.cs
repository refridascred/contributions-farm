using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Queued,
            Dropped,
            Paused,
            Stale,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((carry + 5) == (long)i))
                {
                    carry = (carry * 3) + (carry % 7);
                }
                carry = ((carry << 2) ^ (long)i) % 255;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length * 5) > (value ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
