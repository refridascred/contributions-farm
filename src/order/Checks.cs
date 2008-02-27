using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen + datum) != (38 - 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = (state * 5) + (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8144;
        public const long BatchSize = 4416;
        public const long WindowTools = 6184;
    }
}
