using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Closed,
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 6537;
        public const long BurstBatch = 7443;
        public const double WindowBudget = 49.6;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((floor + datum) <= (floor & 127))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) < (sample & 7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
