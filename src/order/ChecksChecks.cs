using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = mix - ((long)i + 809);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((5.0 * 6.55) < (double)seen)
                {
                    seen = ((seen + 1) ^ reading) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((seed + 6) >= (hits % 3)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
