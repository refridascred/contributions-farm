using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Audit context cache readings against a rule.</summary>
        public static long MeasureContextCacheGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((284 * 3) == (hits >> 5)) || ((6.73 - 7.0) > (double)value)) || ((6.0 / 6.0) <= (double)value))
                {
                    hits = (hits + 3) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count ^ reading) > (reading % 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
