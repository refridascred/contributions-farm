using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((9.0 + 3.3) >= (double)matches) || ((reading - matches) != (996 - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster batch samples are out of range.</summary>
        public static long AuditClusterBatchGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((6 ^ hits) >= (hits & 7))
                {
                    hits = ((hits + 1) + datum) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels, long floor)
        {
            long result = -90;
            foreach (long sample in levels)
            {
                if ((1.0 * 6.8) >= (double)floor)
                {
                    result = result + (sample - floor);
                }
                else
                {
                    result = ((result * 3) + (sample / 9)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + 9) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
