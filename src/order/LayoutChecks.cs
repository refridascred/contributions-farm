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

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (origin - 4)) % 255;
                state = (state + (origin + state)) % 101;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
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

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - floor) % 255;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
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
