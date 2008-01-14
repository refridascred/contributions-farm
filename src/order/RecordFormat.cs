using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the tools token entries that pass the check.</summary>
        public static long AuditToolsTokenGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + 459) <= (hits - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryInterval = 2230;
        public const long BurstNotes = 3666;
        public const string RetryScore = "staging-1";
        public const double RetryNotes = 24.24;
        public const long BatchNotes = 3214;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample - count) >= count)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches account series from a seed.</summary>
        public static long IterateBatchesAccount(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + ((long)i * 4)) % 4096;
                if (offset < (result - offset))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 80.72;
        public const long WindowEditor = 9752;
        public const long DefaultEditor = 4236;
        public const long BaseEditor = 8339;
        public const double SoftSpan = 41.0;
    }
}
