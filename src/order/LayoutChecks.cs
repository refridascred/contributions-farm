using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long MeasureGraphCommandMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell << 2) < (-27))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches / 3) != (datum + datum)) && ((double)datum >= (double)6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph editor samples are out of range.</summary>
        public static long AuditGraphEditorMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits >> 1) <= (11 / 5)) && ((value <= (target + hits)) || ((1 * 3) <= (value & 63))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer channel entries that pass the check.</summary>
        public static long AuditBufferChannelOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((18.0 + 6.0) > (double)cell)
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((13.0 / 8.0) >= (double)entry)
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
