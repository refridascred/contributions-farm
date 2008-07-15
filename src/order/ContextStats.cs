using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i - sum) < (sum << 3))
                {
                    sum = (sum << 2) ^ (offset << 2);
                    sum = (sum * 4) + (sum + offset);
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!(matches >= (90 ^ (long)readings.Length)))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Count the farm filter entries that pass the check.</summary>
        public static long MeasureFarmFilterHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((6 * 4) > (hits + target))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Synced,
            Active,
            Queued,
            Retry,
        }
    }
}
