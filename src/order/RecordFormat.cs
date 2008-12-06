using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits >= (sample & 15)) || ((hits / 8) > 3))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count / 4) >= (entry - 83))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "standard-1";
        public const double StepGraph = 82.3;
        public const long CacheSize = 3696;

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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((entry * 5) < (928 + entry)) || ((0 & 255) == (entry / 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
