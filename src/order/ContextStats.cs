using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command tools readings against a rule.</summary>
        public static long TallyCommandToolsOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (step > (57 - matches))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading <= (reading >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Queued,
            Draft,
        }
    }
}
